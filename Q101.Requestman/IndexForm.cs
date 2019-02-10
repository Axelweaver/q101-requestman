using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q101.Requestman.Converters;
using Q101.Requestman.Helpers;
using Q101.Requestman.Models;

namespace Q101.Requestman
{
    /// <summary>
    /// Main Application Form 
    /// </summary>
    public partial class IndexForm : Form
    {
        private readonly BindingList<StatisticItemViewModel> _statisticList 
            = new BindingList<StatisticItemViewModel>();

        private readonly StringToHttpMethodConverterMethodsList _methodsList;

        /// <summary>
        /// Constructor
        /// </summary>
        public IndexForm()
        {
            InitializeComponent();

            _methodsList = new StringToHttpMethodConverterMethodsList();

            RequestTypeComboBox.DataSource =
                _methodsList
                    .List
                    .Select(l => l.Key.ToUpper())
                    .ToArray();

            RequestHeadersTextBox.Text = "User-Agent: Q101.Requestman";

            StatisticDataGrid.DataSource = _statisticList;
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {

            await SendRequest();
        }

        private async Task SendRequest()
        {

            var id = _statisticList.Count == 0
                ? 1
                : _statisticList.Count + 1;

            var statisticItem = new StatisticItemViewModel
            {
                Id = id,
                Url = UrlTextBox.Text
            };
            _statisticList.Add(statisticItem);
 
            var processing = new RequestProcessing(
                new RequestHelper(), 
                new StringToHttpMethodConverter(_methodsList.List)
                );

            var request = new RequestModel
            {
                DateTime = DateTime.Now,
                Url = UrlTextBox.Text,
                Method = RequestBodyTextBox.SelectedText,
                Headers = RequestHeadersTextBox.Text.Split('\n'),
                Body = RequestBodyTextBox.Text
            };

            await processing.SendRequest(request);

            var duration = (request.Response.TimeStamp - request.DateTime).TotalMilliseconds;

            statisticItem.Status = request.Response.HttpStatusCode;
            statisticItem.Duration = $"{duration} ms";

            _statisticList[id - 1] = statisticItem;
        }
    }
}
