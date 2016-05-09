using EnvDTE;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeReview
{
    public partial class RecordForm : Form
    {
        DTE2 _applicationObject;
        Model.RecordInfoModel recordModel;

        public RecordForm(DTE2 det2)
        {
            InitializeComponent();
            recordModel = new Model.RecordInfoModel();
            _applicationObject = det2;

            InitData();
        }

        public bool InitSuccess
        {
            get; set;
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

        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <returns></returns>
        private void InitData()
        {
            try
            {
                ProjectItem projectItem = _applicationObject.ActiveDocument.ProjectItem;
                FileCodeModel fileCodeModel = projectItem.FileCodeModel;
                if (fileCodeModel.Language == CodeModelLanguageConstants.vsCMLanguageCSharp)

                {
                    EnvDTE.TextSelection txtSelection = _applicationObject.ActiveDocument.Selection as EnvDTE.TextSelection;
                    CodeElement codeEmelemt = null;
                    codeEmelemt = fileCodeModel.CodeElementFromPoint(txtSelection.TopPoint, vsCMElement.vsCMElementFunction);
                    if (null != codeEmelemt)
                        txtMethodName.Text = codeEmelemt.Name;

                    recordModel.CodeLineNumber = txtSelection.TopLine;
                    recordModel.SelectedCode = txtCodeContent.Text = txtSelection.Text;
                    recordModel.ProjectName = _applicationObject.ActiveWindow.Project.Name;
                    recordModel.FileFullPath = _applicationObject.ActiveDocument.FullName;
                }
                InitSuccess = true;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
