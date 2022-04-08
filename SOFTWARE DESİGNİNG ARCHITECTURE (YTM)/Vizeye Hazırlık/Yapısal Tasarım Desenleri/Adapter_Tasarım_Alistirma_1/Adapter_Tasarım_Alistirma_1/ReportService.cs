using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Tasarım_Alistirma_1
{
    public class ReportService
    {
        private readonly IReportProducer reportProducer;
        public ReportService(IReportProducer reportProducer)
        {
            this.reportProducer = reportProducer;
        }
        public void CreateReport()
        {
            reportProducer.CreateReport(new Report());
        }
    }
}
