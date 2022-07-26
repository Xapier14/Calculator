using Cerulean;
using Cerulean.Core;
using Cerulean.Common;
using Cerulean.Components;

using Calculator.Mathematics;

namespace Cerulean.App
{
    public partial class MainLayout
    {
        private Label DisplayLabel => DynamicLayout.ResponsiveGrid.BaseGrid.DisplayPanel.DisplayLabel;
        private bool _wasEval = false;
        public override void Init()
        {
            DynamicLayout.ResponsiveGrid.SetColumnWidth(1, 512);
            DynamicLayout.ResponsiveGrid.SetRowHeight(1, 512);
            DynamicLayout.ResponsiveGrid.BaseGrid.SetRowHeight(0, 64);
        }

        #region Buttons
        public void ButtonAddText_OnClick(object? caller, ButtonEventArgs eventArgs)
        {
            if (_wasEval)
                DisplayLabel.Text = string.Empty;
            var button = (Button)caller;
            DisplayLabel.Text += button.Text;
            _wasEval = false;
        }
        public void ButtonClear_OnClick(object? caller, ButtonEventArgs eventArgs)
        {
            DisplayLabel.Text = string.Empty;
            _wasEval = false;
        }
        public void ButtonEval_OnClick(object? caller, ButtonEventArgs eventArgs)
        {
            string input = DisplayLabel.Text;
            string result = string.Empty;
            try
            {
                var tokens = Algorithm.TokenizeExpression(input);
                tokens = Algorithm.ShuntingYard(tokens);
                result = Algorithm.EvaluatePostFix(tokens).ToString();
            }
            catch (Exception)
            {
                result = "ERROR";
            }
            DisplayLabel.Text = result;
            _wasEval = true;
        }
        #endregion
    }
}