using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using CUITe.Controls.HtmlControls;

namespace CodedUITestProject7.ObjectRepository
{
    public class LoginPage //: CUITe_BrowserWindow
    {
        public CUITe_HtmlEdit txtLOGINCTLT1 = new CUITe_HtmlEdit("Id=LOGINCTL_T1");
        public CUITe_HtmlPassword txtLOGINCTLT2 = new CUITe_HtmlPassword("Id=LOGINCTL_T2");
        public CUITe_HtmlEdit txtLOGINCTLT3 = new CUITe_HtmlEdit("Id=LOGINCTL_T3");
        public CUITe_HtmlSpan spnProcessingPleaseWait = new CUITe_HtmlSpan("Id=IAccept");
        //public new string sWindowTitle = "uat16. Eduneering";
        public CUITe_HtmlHyperlink lnkTestTrainingItem = new CUITe_HtmlHyperlink("InnerText=Test Training item;Title=Click to Launch Course");
        public CUITe_HtmlHyperlink lnkContinue = new CUITe_HtmlHyperlink("Id=continueLink");
        public CUITe_HtmlDiv divTemp1 = new CUITe_HtmlDiv("Id=divCDWindow");
    }
}
