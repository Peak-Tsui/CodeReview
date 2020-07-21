using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TextManager.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeReview.View
{

    public partial class RecordForm : Form
    {
        DTE2 _applicationObject;
        Model.RecordInfoModel recordModel;
        IAsyncServiceProvider ServiceProvider { get; }
        public RecordForm(IAsyncServiceProvider serviceProvider)
        {
            InitializeComponent();
            recordModel = new Model.RecordInfoModel();
            ServiceProvider = serviceProvider;
            InitData();
        }

        public bool InitSuccess
        {
            get; set;
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <returns></returns>
        private void InitData()
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();
            try
            {
                //IVsTextManager txtMgr = (IVsTextManager) ServiceProvider.GetServiceAsync(typeof(SVsTextManager)).Result;
                //int mustHaveFocus = 1;
                //IVsTextView vTextView = null;
                //txtMgr.GetActiveView(mustHaveFocus, null, out vTextView);
                //string selectedTxt;
                //var n = vTextView.GetSelectedText(out selectedTxt);

                 var dte = ServiceProvider.GetServiceAsync(typeof(DTE)).Result;
                _applicationObject = (DTE2)dte;

                ProjectItem projectItem = _applicationObject.ActiveDocument.ProjectItem;
                FileCodeModel fileCodeModel = projectItem.FileCodeModel;
                if (fileCodeModel != null && fileCodeModel.Language == CodeModelLanguageConstants.vsCMLanguageCSharp)

                {
                    EnvDTE.TextSelection txtSelection = _applicationObject.ActiveDocument.Selection as EnvDTE.TextSelection;
                    CodeElement codeEmelemt = null;
                    try
                    {
                        //codeEmelemt = fileCodeModel.CodeElementFromPoint(txtSelection.TopPoint, vsCMElement.vsCMElementFunction);
                        codeEmelemt = txtSelection.ActivePoint.CodeElement[vsCMElement.vsCMElementFunction];
                        if (null != codeEmelemt)
                            txtMethodName.Text = codeEmelemt.Name;
                    }
                    catch (Exception ex1)
                    {
                        txtMethodName.Text = ex1.Message;
                    }

                    recordModel.CodeLineNumber = txtSelection.TopLine;
                    recordModel.SelectedCode = txtCodeContent.Text = txtSelection.Text;
                    recordModel.ProjectName = _applicationObject.ActiveWindow.Project.Name;
                    recordModel.FileFullPath = _applicationObject.ActiveDocument.FullName;
                    recordModel.MethodName = txtMethodName.Text;
                }
                else //
                {
                    EnvDTE.TextSelection txtSelection = _applicationObject.ActiveDocument.Selection as EnvDTE.TextSelection;
                    txtMethodName.Text = "";

                    recordModel.CodeLineNumber = txtSelection.TopLine;
                    recordModel.SelectedCode = txtCodeContent.Text = txtSelection.Text;
                    recordModel.ProjectName = _applicationObject.ActiveWindow.Project.Name;
                    recordModel.FileFullPath = _applicationObject.ActiveDocument.FullName;

                }
                InitSuccess = true;
            }
            catch (Exception ex)
            {
                InitSuccess = false;
            }
        }


        private void btnSure_Click(object sender, EventArgs e)
        {
            try
            {
                recordModel.Engineer = txtFixer.Text;
                recordModel.PlanCloseDate = DateTime.Parse(dateFixTime.Text);
                recordModel.Question = txtQuestion.Text;
                recordModel.Suggestion = txtSuggest.Text;

                Biz.ISaveReview saver = Biz.SaverFactory.GetSaver();
                saver.Save(recordModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
