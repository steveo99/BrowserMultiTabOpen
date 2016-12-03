using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace BrowserMultiTabOpen
{
    public partial class InvestmentStockReasearch : Form {
        public InvestmentStockReasearch() {
            InitializeComponent();
        }

        private void OpenListButtonClick(object sender, EventArgs e) {
            var stockSymbol = StockSymbolTextBox.Text;
            OpenList(stockSymbol);
        }

        private void OpenList(string stockSymbol) {
            const int millisecondsTimeout = 1500;

            // CNN Money
            var url = string.Format("http://money.cnn.com/quote/quote.html?symb={0}", stockSymbol);
            StartProcess(url);
            Thread.Sleep(millisecondsTimeout);

            // StockTwits
            url = string.Format("http://stocktwits.com/symbol/{0}?q={0}", stockSymbol);
            StartProcess(url);
            Thread.Sleep(millisecondsTimeout);

            // Yahoo Finance
            url = string.Format("https://finance.yahoo.com/quote/{0}?p={0}", stockSymbol);
            StartProcess(url);
            Thread.Sleep(millisecondsTimeout);

            // Google Finance
            url = string.Format("https://www.google.com/finance?q={0}", stockSymbol);
            StartProcess(url);
            Thread.Sleep(millisecondsTimeout);

            // MarketWatch
            url = string.Format("http://www.marketwatch.com/investing/Stock/{0}", stockSymbol);
            StartProcess(url);
            Thread.Sleep(millisecondsTimeout);

            // MSN Money
            url = string.Format("http://www.msn.com/en-us/money/stockdetails?symbol={0}", stockSymbol);
            StartProcess(url);
            Thread.Sleep(millisecondsTimeout);

            // Morningstar
            url = string.Format("http://beta.morningstar.com/stocks/xnys/{0}/quote.html", stockSymbol);
            StartProcess(url);
            Thread.Sleep(millisecondsTimeout);

            // Seeking Alpha
            url = string.Format("http://seekingalpha.com/symbol/{0}", stockSymbol);
            StartProcess(url);
            Thread.Sleep(millisecondsTimeout);

            // gurufocus
            url = string.Format("http://www.gurufocus.com/stock/{0}", stockSymbol);
            StartProcess(url);

        }

        private static void StartProcess(string url) {
            Debug.WriteLine(url);
            try {
                var pi = new ProcessStartInfo(url);
                Process.Start(pi);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
