using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncherWinFormsGames
{
    public partial class MainMenu : Form
    {
        private LogINpage previousForm;
        private LogINpage loginForm;
        private string username;

        public MainMenu(LogINpage form1, LogINpage loginForm)
        {
            InitializeComponent();
            previousForm = form1;
            this.loginForm = loginForm;
            string loggedInUsername = loginForm.GetLoggedInUsername();
            LoginLabel.Text = loggedInUsername;
            username = loginForm.GetLoggedInUsername();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            CasualGames formcasual = new CasualGames(this, username);

            // Скрытие текущей формы
            this.Hide();

            // Отображение новой формы
            formcasual.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            ShooterGames formshooters = new ShooterGames(this);

            // Скрытие текущей формы
            this.Hide();

            // Отображение новой формы
            formshooters.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            RaceGames formraces = new RaceGames(this);

            // Скрытие текущей формы
            this.Hide();

            // Отображение новой формы
            formraces.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string loggedInUsername = loginForm.GetLoggedInUsername();
            string connectionString = "Data Source=MASARUPC\\SQLEXPRESS01;Initial Catalog=LauncherGamesBD;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT AvatarPath FROM Users WHERE Login = @Login";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", loggedInUsername);

                    string photoPath = command.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(photoPath))
                    {
                        AvatarBox.BackgroundImage = Image.FromFile(photoPath);
                        AvatarBox.BackgroundImageLayout = ImageLayout.Stretch;
                        AvatarBox.BorderStyle = BorderStyle.FixedSingle;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string loggedInUsername = loginForm.GetLoggedInUsername();
            string photoPath = "";

            if (AvatarBox.BackgroundImage != null)
            {
                Image backgroundImage = AvatarBox.BackgroundImage;
                if (backgroundImage.Tag is string path)
                {
                    photoPath = path;
                }
            }

            ProfilePage profilePage = new ProfilePage(this, loggedInUsername, photoPath); // Передаем предыдущую форму в конструктор
            profilePage.Show();

            // Скрытие текущей формы
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
