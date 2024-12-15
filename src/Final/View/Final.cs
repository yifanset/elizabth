using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Text.Json.Serialization;
using System.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace Final
{
    public partial class Final : Form
    {
        private List<Establishment> _establishment = new List<Establishment>();
        private Establishment _currentEstablishment;

        public Final()
        {
            InitializeComponent();
        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            try
            {
                Establishment addEstablisment = new Establishment(
                    nameTextBox.Text, addressTextBox.Text,
                    categoryComboBox.SelectedItem.ToString(),
                    Convert.ToDouble(ratingTextBox.Text));
                _establishment.Add(addEstablisment);

                establishmentListBoxClear();
                establishmentSort();
            }
            catch
            {
                MessageBox.Show("Поля не заполнены или заполнены с ошибками");

            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (establishmentListBox.SelectedIndex >= 0 &&
                    establishmentListBox.SelectedIndex
                    < _establishment.Count)
                {
                    _establishment[establishmentListBox.SelectedIndex].Name
                        = nameTextBox.Text;
                    _establishment[establishmentListBox.SelectedIndex].Address
                        = addressTextBox.Text;
                    _establishment[establishmentListBox.SelectedIndex].Category
                        = categoryComboBox.SelectedItem.ToString();
                    _establishment[establishmentListBox.SelectedIndex].Raiting
                        = Convert.ToDouble(ratingTextBox.Text);

                    appendButton.Enabled = true;

                    establishmentListBoxClear();
                    establishmentSort();
                }
                else
                {
                    MessageBox.Show("Элемент не выбран");
                }
            }
            catch {
                MessageBox.Show("Поля не заполнены или заполнены с ошибками");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (establishmentListBox.SelectedIndex >= 0 &&
                    establishmentListBox.SelectedIndex < _establishment.Count)
                {
                    _establishment.RemoveAt(
                        establishmentListBox.SelectedIndex);
                    establishmentListBox.Items.RemoveAt(
                        establishmentListBox.SelectedIndex);

                    appendButton.Enabled = true;

                    establishmentListBoxClear();
                }
                else
                {
                    MessageBox.Show("Элемент не выбран");
                }
            }
            catch { }
        }

        private void establishmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (establishmentListBox.SelectedIndex >= 0 &&
                establishmentListBox.SelectedIndex < _establishment.Count)
            {
                _currentEstablishment = _establishment[
                    establishmentListBox.SelectedIndex];
                nameTextBox.Text = _currentEstablishment.Name;
                addressTextBox.Text = _currentEstablishment.Address;
                categoryComboBox.SelectedIndex = Convert.ToInt32(
                    Enum.Parse<Category>(_currentEstablishment.Category));
                ratingTextBox.Text = _currentEstablishment.Raiting.ToString();

                appendButton.Enabled = false;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nameTextBox.BackColor = System.Drawing.Color.White;
                Validator.AssertForMaximumLength(nameTextBox.Text, 200);
            }
            catch
            {
                nameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                addressTextBox.BackColor = System.Drawing.Color.White;
                Validator.AssertForMaximumLength(addressTextBox.Text, 100);
            }
            catch
            {
                addressTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ratingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(ratingTextBox.Text, out double value))
            {
                try
                {
                    ratingTextBox.BackColor = System.Drawing.Color.White;
                    Validator.AssertOnPositiveValue(value, 5);
                }
                catch
                {
                    ratingTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
            else
            {
                ratingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private async void Final_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData)
                + @"\establishment.txt"))
            {
                using FileStream readStream = new FileStream(
                    Environment.GetFolderPath
                    (Environment.SpecialFolder.ApplicationData)
                    + @"\establishment.txt", FileMode.OpenOrCreate);

                _establishment = await JsonSerializer.DeserializeAsync
                    <List<Establishment>>(readStream);

                foreach (var item in _establishment)
                {
                    establishmentListBox.Items.Add(item.Category
                        + " - " + item.Name);
                }
            }
            else
            {
                using (FileStream fs = File.Create
                    (Environment.GetFolderPath
                    (Environment.SpecialFolder.ApplicationData)
                    + @"\establishment.txt"))
                {

                }
            }
        }

        private void Final_FormClosed(object sender, FormClosedEventArgs e)
        {
            using FileStream createStream = File.Create
                (Environment.GetFolderPath
                (Environment.SpecialFolder.ApplicationData)
                + @"\establishment.txt");

            JsonSerializer.SerializeAsync(createStream, _establishment);
        }

        private void Final_Click(object sender, EventArgs e)
        {
            if (establishmentListBox.SelectedIndex >= 0 &&
                    establishmentListBox.SelectedIndex
                    < _establishment.Count)
            {
                establishmentListBox.SetSelected(0, false);
                establishmentListBoxClear();
                appendButton.Enabled = true;
            }
        }

        /// <summary>
        /// Сортировка списка
        /// </summary>
        public void establishmentSort()
        {
            _establishment = _establishment.OrderBy
                (s => s.Category).ThenBy(s => s.Name).ToList();
            establishmentListBox.Items.Clear();

            foreach (var item in _establishment)
            {
                establishmentListBox.Items.Add(item.Category
                    + " - " + item.Name);
            }
        }

        /// <summary>
        /// Очищает поля заполнения.
        /// </summary>
        public void establishmentListBoxClear()
        {
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            categoryComboBox.Items.Clear();
            ratingTextBox.Text = "";

            nameTextBox.BackColor = Color.White;
            addressTextBox.BackColor = Color.White;
            ratingTextBox.BackColor = Color.White;

            categoryComboBox.Items.Add
                (Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
        }
    }
}
