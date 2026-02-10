using System.Collections.Generic;
using System.Windows.Forms;
using sellular_shop.Filtering;

namespace sellular_shop.UI
{
    public class FilterDialog : Form
    {
        private readonly ComboBox _fieldComboBox;
        private readonly TextBox _valueTextBox;
        private readonly CheckBox _regexCheckBox;

        public FilterDialog(List<FilterColumnOption> columns)
        {
            Text = "Параметры фильтра";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Width = 420;
            Height = 230;

            Label fieldLabel = new Label { Left = 20, Top = 20, Width = 360, Text = "Поле для поиска" };
            _fieldComboBox = new ComboBox
            {
                Left = 20,
                Top = 45,
                Width = 360,
                DropDownStyle = ComboBoxStyle.DropDownList,
                DisplayMember = "DisplayName",
                DataSource = columns
            };

            Label valueLabel = new Label
            {
                Left = 20,
                Top = 80,
                Width = 360,
                Text = "Что искать (поддержка операторов: >, <, >=, <=, =, !=)"
            };
            _valueTextBox = new TextBox { Left = 20, Top = 105, Width = 360 };

            _regexCheckBox = new CheckBox
            {
                Left = 20,
                Top = 135,
                Width = 360,
                Text = "Использовать регулярное выражение"
            };

            Button okButton = new Button
            {
                Text = "Применить",
                Left = 224,
                Width = 75,
                Top = 160,
                DialogResult = DialogResult.OK
            };

            Button cancelButton = new Button
            {
                Text = "Отмена",
                Left = 305,
                Width = 75,
                Top = 160,
                DialogResult = DialogResult.Cancel
            };

            AcceptButton = okButton;
            CancelButton = cancelButton;

            Controls.Add(fieldLabel);
            Controls.Add(_fieldComboBox);
            Controls.Add(valueLabel);
            Controls.Add(_valueTextBox);
            Controls.Add(_regexCheckBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
        }

        public FilterColumnOption SelectedColumn => _fieldComboBox.SelectedItem as FilterColumnOption;

        public string SearchValue => _valueTextBox.Text;

        public bool UseRegex => _regexCheckBox.Checked;
    }
}
