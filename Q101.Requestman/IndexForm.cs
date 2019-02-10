using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Q101.Requestman.Converters;
using Q101.Requestman.Models;

namespace Q101.Requestman
{
    /// <summary>
    /// Main Application Form 
    /// </summary>
    public partial class IndexForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public IndexForm()
        {
            InitializeComponent();

            RequestTypeComboBox.DataSource =
                new StringToHttpMethodConverterMethodsList()
                    .List
                    .Select(l => l.Key.ToUpper())
                    .ToArray();

            RequestHeadersTextBox.Text = "User-Agent: Q101.Requestman";

            StatisticDataGrid.DataSource = new List<StatisticItemViewModel>()
            {
                new StatisticItemViewModel
                {
                    Id = 1,
                    Url = "https://www.example.com/",
                    Status = 200,
                    Duration = "300 ms"
                },
               new StatisticItemViewModel
                {
                    Id = 2,
                    Url = "https://www.example.com/",
                    Status = 200,
                    Duration = "300 ms"
                },
               new StatisticItemViewModel
                {
                    Id = 3,
                    Url = "https://www.example.com/",
                    Status = 200,
                    Duration = "300 ms"
                }
            };
        }
    }
}
