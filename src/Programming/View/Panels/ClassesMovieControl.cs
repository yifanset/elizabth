using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class ClassesMovieControl : UserControl
    {
        private Movie[] _movies;
        private Movie _currentMovies;
        public ClassesMovieControl()
        {
            InitializeComponent();
            Random random = new Random();
            _movies = new Movie[5];
            for (int i = 0; i < 5; i++)
            {
                _movies[i] = new Movie($"Фильм {i}", 1, 1950, "Horror",
                    random.Next(1, 10) + Math.Round(random.NextDouble(), 1));
            }
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovies = _movies[MovieListBox.SelectedIndex];
            NameTextBox.Text = _currentMovies.Name.ToString();
            GenreTextBox.Text = _currentMovies.Genre.ToString();
            RaitingTextBox.Text = _currentMovies.Raiting.ToString();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _movies[MovieListBox.SelectedIndex].Name = NameTextBox.Text;
                NameTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _movies[MovieListBox.SelectedIndex].Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                GenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RaitingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _movies[MovieListBox.SelectedIndex].Raiting
                    = Convert.ToDouble(RaitingTextBox.Text);
                RaitingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RaitingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        /// <summary>
        /// Находит индекс фильма по максимальному рейтингу
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private int FindMovieWithMaxRaiting(Movie[] movies)
        {
            int maxIndex = 0;
            double maxRaiting = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (maxRaiting < movies[i].Raiting)
                {
                    maxRaiting = movies[i].Raiting;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int maxIndex = FindMovieWithMaxRaiting(_movies);
            MovieListBox.SelectedIndex = maxIndex;
        }
    }
}
