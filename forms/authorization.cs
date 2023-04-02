using System;
using System.Drawing;
using MyWoggi.forms;
using System.Windows.Forms;
using System.IO;

namespace MyWoggi
{
    public partial class Authorization : Form
    {

        // Подключение базы данных
        Database MyWoggi = new Database();


        // Заполнители для текстовых полей
        string loginPlaceholder = "Ваш никнейм";
        string pwdPlaceholder = "Ваш пароль";

        private string authTokenFilePath;
        // Путь к файлу, в котором будет храниться логин пользователя
        private string userLoginFilePath;

        // Токен авторизации
        private string authToken;


        public Authorization()
        {
            InitializeComponent();

            // Собираем путь к файлу токена авторизации
            authTokenFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "authtoken.txt");

            // Собираем путь к файлу логина пользователя
            userLoginFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "login.txt");
        }

        // Генерирует новый токен авторизации и сохраняет его в файл, вместе с логином пользователя
        private void GenerateAuthTokenLogin(string userLogin)
        {
            // Если файлы с токеном и логином пользователя не существуют
            if (!File.Exists(authTokenFilePath) && !File.Exists(userLoginFilePath))
            {
                try
                {
                    // Генерируем новый токен авторизации
                    Guid authToken = Guid.NewGuid();
                    string loginUser = userLogin;

                    // Записываем токен авторизации в файл
                    FileStream filestream = new FileStream(authTokenFilePath, FileMode.Create);
                    StreamWriter streamwriter = new StreamWriter(filestream);
                    streamwriter.WriteLine(authToken);
                    streamwriter.Close();
                    filestream.Close();

                    // Записываем логин пользователя в файл
                    FileStream filestream1 = new FileStream(userLoginFilePath, FileMode.Create);
                    StreamWriter streamwriter1 = new StreamWriter(filestream1);
                    streamwriter1.WriteLine(loginUser);
                    streamwriter1.Close();
                    filestream1.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        // Считывает токен авторизации из файла
            private string ReadAuthToken()
            {
                FileStream fileStream = new FileStream(authTokenFilePath, FileMode.Open);
                StreamReader streamReader = new StreamReader(fileStream);
                string authToken = streamReader.ReadLine();
                streamReader.Close();
                fileStream.Close();
                return authToken;
            }

        // Считывает логин пользователя из файла
        private string ReadUserLogin()
        {
            FileStream fileStream = new FileStream(userLoginFilePath, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            string loginUser = streamReader.ReadLine();
            streamReader.Close();
            fileStream.Close();
            return loginUser;
        }
        public void SetPlaceholder(TextBox textBox, string placeholder)
        {
            // Если текстбокс содержит плейсхолдер
            if (textBox.Text == placeholder)
            {
                textBox.Text = ""; // Очистить текстбокс
                textBox.ForeColor = Color.Black; // Изменить цвет текста на черный
            }
            // Если текстбокс пуст
            else if (textBox.Text == "")
            {
                textBox.PasswordChar = '\0'; // Отключить скрытие символов пароля
                textBox.Text = placeholder; // Вставить плейсхолдер
                textBox.ForeColor = Color.Gray; // Изменить цвет текста на серый
            }
        }

        public bool isUserRemembered()
        {
            if (File.Exists(userLoginFilePath))
            {
                string loginUser = ReadUserLogin();
                string checkAuthTokenQueryString = $"select id_user, authtoken_user from Userdata " +
        $"where login_user = '{loginUser}' and rememberme_user = '1'";

                bool isRememberMe = MyWoggi.SelectData(checkAuthTokenQueryString);
                if (isRememberMe)
                {
                    return true;
                }
            }
            return false;
        }


        // Подгрузка формы
        private void Authorization_Load(object sender, EventArgs e)
        {

            // Когда форма загружена, login_placeholder назначается login_textbox и изменяется цвет
            login_textbox.Text = loginPlaceholder;
            login_textbox.ForeColor = Color.Gray;

            // Когда форма загружена, pwd_placeholder назначается pwd_textbox и изменяется цвет
            pwd_textbox.Text = pwdPlaceholder;
            pwd_textbox.ForeColor = Color.Gray;

        }

        // Когда пользователь нажимает X в какой-то форме, приложение закрывается
        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Когда пользователь наводит курсор на login_textbox, login_textbox очищается, и изменяется цвет
        private void Login_textbox_Enter(object sender, EventArgs e)
        {
            SetPlaceholder(login_textbox, loginPlaceholder);
        }

        // Когда пользователь переключается на другое текстовое поле, а login_textbox пустое, login_placeholder назначается login_textbox
        private void Login_textbox_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(login_textbox, loginPlaceholder);

        }

        // Когда пользователь наводит курсор на pwd_textbox, pwd_textbox очищается, и изменяется цвет
        private void Pwd_textbox_Enter(object sender, EventArgs e)
        {

            if (showPwd_picturebox.Visible == false)
                pwd_textbox.PasswordChar = '•';

            SetPlaceholder(pwd_textbox, pwdPlaceholder);

        }

        // Когда пользователь переключается на другое текстовое поле, а pwd_textbox пустое, pwd_placeholder назначается pwd_textbox
        private void Pwd_textbox_Leave(object sender, EventArgs e)
        {

            SetPlaceholder(pwd_textbox, pwdPlaceholder);
        }

        // Когда пользователь нажимает кнопку "Забыл пароль"
        private void ForgotPwd_button_Click(object sender, EventArgs e)
        {
            // Переключение на форму forgotpwd_email
            ForgotPwdEmail forgotpwd_email = new ForgotPwdEmail();
            forgotpwd_email.Show();
            this.Hide();
        }

        // Когда пользователь нажимает на картинку "показать пароль"
        private void ShowPwd_picturebox_Click(object sender, EventArgs e)
        {
            // Показываем картинку для скрытия пароля и скрываем картинку для его отображения
            hidePwd_picturebox.Visible = true;
            showPwd_picturebox.Visible = false;

            // Заменяем символы пароля на символы-заглушки
            pwd_textbox.PasswordChar = '•';

            // Если поле ввода пароля содержит плейсхолдер, то заменяем символы-заглушки на обычные символы
            if (pwd_textbox.Text == pwdPlaceholder)
                pwd_textbox.PasswordChar = '\0';
        }

        // Когда пользователь нажимает на картинку "скрыть пароль"
        private void HidePwd_picturebox_Click(object sender, EventArgs e)
        {
            // Показываем картинку для отображения пароля и скрываем картинку для его скрытия
            hidePwd_picturebox.Visible = false;
            showPwd_picturebox.Visible = true;

            // Заменяем символы-заглушки на обычные символы
            pwd_textbox.PasswordChar = '\0';

            // Если поле ввода пароля содержит плейсхолдер, то заменяем обычные символы на символы-заглушки
            if (pwd_textbox.Text == pwdPlaceholder)
                pwd_textbox.PasswordChar = '•';


        }

        // Когда пользователь нажимает кнопку Войти
        private void Login_button_Click(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            var loginUser = login_textbox;
            var pwdUser = pwd_textbox;

            // Формируем запрос для проверки наличия пользователя в БД
            string checkUserQueryString = $"select id_user, login_user, password_user from Userdata " +
            $"where login_user = '{loginUser.Text}' and password_user = '{pwdUser.Text}'";

            // Проверяем, есть ли такой пользователь в БД
            bool isLogged = MyWoggi.SelectData(checkUserQueryString);

            // Если пользователь найден и пользователь выбрал запомнить меня
            if (isLogged && rememberme_checkbox.Checked)
            {
                // Генерируем токен авторизации и записываем в файл
                GenerateAuthTokenLogin(loginUser.Text);
                // Получаем токен авторизации из файла
                authToken = ReadAuthToken();

                // Формируем запрос на обновление токена авторизации и отметки запомнить меня в БД
                string insertAuthTokenQueryString = $"update Userdata set rememberme_user = '1', authtoken_user = '{authToken}' " +
                $"where login_user = '{loginUser.Text}'";
                // Обновляем токен авторизации и отметку запомнить меня в БД
                bool tokenIsUpdated = MyWoggi.InsertUpdateData(insertAuthTokenQueryString);

                if (tokenIsUpdated)
                {
                    Console.WriteLine("Auth Token succesfully updated");
                }
                else
                {
                    Console.WriteLine("Auth Token failed to update");
                }

                // Переходим на главную страницу приложения
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            // Если пользователь найден и пользователь не выбрал запомнить меня
            else if (isLogged)
            {
                // Переходим на главную страницу приложения
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                // Если пользователь не найден, выделяем текстовые поля красным и выводим ошибку
                login_textbox.BackColor = ColorTranslator.FromHtml("#E89696");
                pwd_textbox.BackColor = ColorTranslator.FromHtml("#E89696");
                loginpwdError_label.Visible = true;
                loginpwdError_label.Text = "Неверно введен логин или пароль";
            }

        }

        // Когда пользователь нажимает кнопку Зарегистрироваться
        private void Register_button_Click(object sender, EventArgs e)
        {
            // Переключаемся на форму регистрации
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

    }
}
