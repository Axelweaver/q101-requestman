using System;
using System.Collections.Generic;
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

        private readonly List<RequestModel> _requests =
            new List<RequestModel>();

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

        private void UpdateStatList()
        {
            _statisticList.Clear();

            _requests.ForEach(r => _statisticList.Add( new StatisticItemViewModel
                {
                    Id = r.Id,
                    Url = r.Url,
                    Duration = r.Response is null ? null :  $"{(r.Response.TimeStamp - r.DateTime).TotalMilliseconds} ms",
                    Status = r.Response?.HttpStatusCode
                })
            );
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {

            await SendRequest();
        }

        private async Task SendRequest()
        {

            var id = _requests.Count + 1;
 
            var processing = new RequestProcessing(
                new RequestHelper(), 
                new StringToHttpMethodConverter(_methodsList.List)
                );

            var request = new RequestModel
            {
                Id = id,
                DateTime = DateTime.Now,
                Url = UrlTextBox.Text,
                Method = RequestBodyTextBox.SelectedText,
                Headers = RequestHeadersTextBox.Text.Split('\n'),
                Body = RequestBodyTextBox.Text
            };

            _requests.Add(request);
            UpdateStatList();

            await processing.SendRequest(request);

            UpdateStatList();

            Enabled = false;

            var viewForm = new ViewerForm(request.Response.Content);

            viewForm.Show(this);
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            Text = $"{Text} version {Program.Version}";
        }
    }
}
