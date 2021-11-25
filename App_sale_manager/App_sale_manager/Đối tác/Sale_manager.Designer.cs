
namespace App_sale_manager
{
    partial class Sale_manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.groupBox_general = new System.Windows.Forms.GroupBox();
            this.checkBox_autoDelete = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_endDate = new System.Windows.Forms.DateTimePicker();
            this.label_endDate = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label_startDate = new System.Windows.Forms.Label();
            this.comboBox_Condition = new System.Windows.Forms.ComboBox();
            this.label_Condition = new System.Windows.Forms.Label();
            this.comboBox_saleCondition = new System.Windows.Forms.ComboBox();
            this.label_saleCondition = new System.Windows.Forms.Label();
            this.comboBox_saleMethod = new System.Windows.Forms.ComboBox();
            this.label_saleMethod = new System.Windows.Forms.Label();
            this.comboBox_saleObj = new System.Windows.Forms.ComboBox();
            this.label_saleObj = new System.Windows.Forms.Label();
            this.textBox_saleName = new System.Windows.Forms.TextBox();
            this.label_saleName = new System.Windows.Forms.Label();
            this.groupBox_detail = new System.Windows.Forms.GroupBox();
            this.groupBox_gift = new System.Windows.Forms.GroupBox();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.label_note = new System.Windows.Forms.Label();
            this.textBox_gift = new System.Windows.Forms.TextBox();
            this.label_gift = new System.Windows.Forms.Label();
            this.groupBox_sale = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Condition_Quantity = new System.Windows.Forms.NumericUpDown();
            this.label_Condition_quantity = new System.Windows.Forms.Label();
            this.numericUpDown_Condition_price = new System.Windows.Forms.NumericUpDown();
            this.label_Condition_price = new System.Windows.Forms.Label();
            this.checkBox_priceCondition = new System.Windows.Forms.CheckBox();
            this.numericUpDown_priceReduced = new System.Windows.Forms.NumericUpDown();
            this.comboBox_priceMethod = new System.Windows.Forms.ComboBox();
            this.label_priceReduced = new System.Windows.Forms.Label();
            this.label_priceMethod = new System.Windows.Forms.Label();
            this.button_quit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView_manager = new System.Windows.Forms.DataGridView();
            this.groupBox_general.SuspendLayout();
            this.groupBox_detail.SuspendLayout();
            this.groupBox_gift.SuspendLayout();
            this.groupBox_sale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Condition_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Condition_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_priceReduced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manager)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_general
            // 
            this.groupBox_general.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_general.Controls.Add(this.checkBox_autoDelete);
            this.groupBox_general.Controls.Add(this.dateTimePicker_endDate);
            this.groupBox_general.Controls.Add(this.label_endDate);
            this.groupBox_general.Controls.Add(this.dateTimePicker_startDate);
            this.groupBox_general.Controls.Add(this.label_startDate);
            this.groupBox_general.Controls.Add(this.comboBox_Condition);
            this.groupBox_general.Controls.Add(this.label_Condition);
            this.groupBox_general.Controls.Add(this.comboBox_saleCondition);
            this.groupBox_general.Controls.Add(this.label_saleCondition);
            this.groupBox_general.Controls.Add(this.comboBox_saleMethod);
            this.groupBox_general.Controls.Add(this.label_saleMethod);
            this.groupBox_general.Controls.Add(this.comboBox_saleObj);
            this.groupBox_general.Controls.Add(this.label_saleObj);
            this.groupBox_general.Controls.Add(this.textBox_saleName);
            this.groupBox_general.Controls.Add(this.label_saleName);
            this.groupBox_general.Location = new System.Drawing.Point(12, 15);
            this.groupBox_general.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_general.Name = "groupBox_general";
            this.groupBox_general.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_general.Size = new System.Drawing.Size(898, 271);
            this.groupBox_general.TabIndex = 0;
            this.groupBox_general.TabStop = false;
            this.groupBox_general.Text = "Thông tin ưu đãi chung";
            // 
            // checkBox_autoDelete
            // 
            this.checkBox_autoDelete.AutoSize = true;
            this.checkBox_autoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_autoDelete.Location = new System.Drawing.Point(504, 141);
            this.checkBox_autoDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_autoDelete.Name = "checkBox_autoDelete";
            this.checkBox_autoDelete.Size = new System.Drawing.Size(228, 21);
            this.checkBox_autoDelete.TabIndex = 14;
            this.checkBox_autoDelete.Text = "Tự động xóa ưu đãi khi kết thúc";
            this.checkBox_autoDelete.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(504, 91);
            this.dateTimePicker_endDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker_endDate.TabIndex = 13;
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endDate.Location = new System.Drawing.Point(500, 71);
            this.label_endDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(95, 17);
            this.label_endDate.TabIndex = 12;
            this.label_endDate.Text = "Ngày kết thúc";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(504, 42);
            this.dateTimePicker_startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker_startDate.TabIndex = 11;
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startDate.Location = new System.Drawing.Point(500, 22);
            this.label_startDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(93, 17);
            this.label_startDate.TabIndex = 10;
            this.label_startDate.Text = "Ngày bắt đầu";
            // 
            // comboBox_Condition
            // 
            this.comboBox_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Condition.FormattingEnabled = true;
            this.comboBox_Condition.Items.AddRange(new object[] {
            "Laptop - Macbook",
            "Chuột - Bàn phím",
            "Tai nghe",
            "Thiết bị chơi game (console)",
            "Card màn hình (VGA)",
            "Ram",
            "Bo mạch chủ",
            "Ổ cứng (SSD)",
            "Ổ cứng (HDD)"});
            this.comboBox_Condition.Location = new System.Drawing.Point(28, 240);
            this.comboBox_Condition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Condition.Name = "comboBox_Condition";
            this.comboBox_Condition.Size = new System.Drawing.Size(224, 24);
            this.comboBox_Condition.TabIndex = 9;
            this.comboBox_Condition.Text = "- Chưa chọn -";
            // 
            // label_Condition
            // 
            this.label_Condition.AutoSize = true;
            this.label_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Condition.Location = new System.Drawing.Point(24, 220);
            this.label_Condition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Condition.Name = "label_Condition";
            this.label_Condition.Size = new System.Drawing.Size(114, 17);
            this.label_Condition.TabIndex = 8;
            this.label_Condition.Text = "Mặt hàng ưu đãi:";
            // 
            // comboBox_saleCondition
            // 
            this.comboBox_saleCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_saleCondition.FormattingEnabled = true;
            this.comboBox_saleCondition.Items.AddRange(new object[] {
            "Mặt hàng",
            "Nhà cung cấp"});
            this.comboBox_saleCondition.Location = new System.Drawing.Point(28, 191);
            this.comboBox_saleCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_saleCondition.Name = "comboBox_saleCondition";
            this.comboBox_saleCondition.Size = new System.Drawing.Size(224, 24);
            this.comboBox_saleCondition.TabIndex = 7;
            this.comboBox_saleCondition.Text = "Mặt hàng";
            this.comboBox_saleCondition.TextChanged += new System.EventHandler(this.comboBox_saleCondition_TextChanged);
            // 
            // label_saleCondition
            // 
            this.label_saleCondition.AutoSize = true;
            this.label_saleCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saleCondition.Location = new System.Drawing.Point(24, 171);
            this.label_saleCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_saleCondition.Name = "label_saleCondition";
            this.label_saleCondition.Size = new System.Drawing.Size(85, 17);
            this.label_saleCondition.TabIndex = 6;
            this.label_saleCondition.Text = "Ưu đãi theo:";
            // 
            // comboBox_saleMethod
            // 
            this.comboBox_saleMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_saleMethod.FormattingEnabled = true;
            this.comboBox_saleMethod.Items.AddRange(new object[] {
            "Giảm giá",
            "Giảm giá & Tặng kèm",
            "Tặng kèm"});
            this.comboBox_saleMethod.Location = new System.Drawing.Point(28, 141);
            this.comboBox_saleMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_saleMethod.Name = "comboBox_saleMethod";
            this.comboBox_saleMethod.Size = new System.Drawing.Size(224, 24);
            this.comboBox_saleMethod.TabIndex = 5;
            this.comboBox_saleMethod.Text = "Giảm giá";
            this.comboBox_saleMethod.TextChanged += new System.EventHandler(this.comboBox_saleMethod_TextChanged);
            // 
            // label_saleMethod
            // 
            this.label_saleMethod.AutoSize = true;
            this.label_saleMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saleMethod.Location = new System.Drawing.Point(24, 122);
            this.label_saleMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_saleMethod.Name = "label_saleMethod";
            this.label_saleMethod.Size = new System.Drawing.Size(82, 17);
            this.label_saleMethod.TabIndex = 4;
            this.label_saleMethod.Text = "Loại ưu đãi:";
            // 
            // comboBox_saleObj
            // 
            this.comboBox_saleObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_saleObj.FormattingEnabled = true;
            this.comboBox_saleObj.Items.AddRange(new object[] {
            "Khách thường",
            "Khách vip",
            "Tất cả"});
            this.comboBox_saleObj.Location = new System.Drawing.Point(28, 92);
            this.comboBox_saleObj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_saleObj.Name = "comboBox_saleObj";
            this.comboBox_saleObj.Size = new System.Drawing.Size(224, 24);
            this.comboBox_saleObj.TabIndex = 3;
            this.comboBox_saleObj.Text = "Tất cả";
            // 
            // label_saleObj
            // 
            this.label_saleObj.AutoSize = true;
            this.label_saleObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saleObj.Location = new System.Drawing.Point(24, 71);
            this.label_saleObj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_saleObj.Name = "label_saleObj";
            this.label_saleObj.Size = new System.Drawing.Size(116, 17);
            this.label_saleObj.TabIndex = 2;
            this.label_saleObj.Text = "Đối tượng ưu đãi:";
            // 
            // textBox_saleName
            // 
            this.textBox_saleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_saleName.Location = new System.Drawing.Point(28, 42);
            this.textBox_saleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_saleName.Name = "textBox_saleName";
            this.textBox_saleName.Size = new System.Drawing.Size(403, 22);
            this.textBox_saleName.TabIndex = 1;
            // 
            // label_saleName
            // 
            this.label_saleName.AutoSize = true;
            this.label_saleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saleName.Location = new System.Drawing.Point(24, 22);
            this.label_saleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_saleName.Name = "label_saleName";
            this.label_saleName.Size = new System.Drawing.Size(80, 17);
            this.label_saleName.TabIndex = 0;
            this.label_saleName.Text = "Tên ưu đãi:";
            // 
            // groupBox_detail
            // 
            this.groupBox_detail.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_detail.Controls.Add(this.groupBox_gift);
            this.groupBox_detail.Controls.Add(this.groupBox_sale);
            this.groupBox_detail.Location = new System.Drawing.Point(12, 295);
            this.groupBox_detail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_detail.Name = "groupBox_detail";
            this.groupBox_detail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_detail.Size = new System.Drawing.Size(898, 490);
            this.groupBox_detail.TabIndex = 1;
            this.groupBox_detail.TabStop = false;
            this.groupBox_detail.Text = "Chi tiết ưu đãi";
            // 
            // groupBox_gift
            // 
            this.groupBox_gift.Controls.Add(this.textBox_note);
            this.groupBox_gift.Controls.Add(this.label_note);
            this.groupBox_gift.Controls.Add(this.textBox_gift);
            this.groupBox_gift.Controls.Add(this.label_gift);
            this.groupBox_gift.Enabled = false;
            this.groupBox_gift.Location = new System.Drawing.Point(28, 22);
            this.groupBox_gift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_gift.Name = "groupBox_gift";
            this.groupBox_gift.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_gift.Size = new System.Drawing.Size(852, 142);
            this.groupBox_gift.TabIndex = 0;
            this.groupBox_gift.TabStop = false;
            this.groupBox_gift.Text = "Ưu đãi tặng kèm";
            // 
            // textBox_note
            // 
            this.textBox_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_note.Location = new System.Drawing.Point(14, 101);
            this.textBox_note.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(502, 22);
            this.textBox_note.TabIndex = 13;
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_note.Location = new System.Drawing.Point(9, 80);
            this.label_note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(167, 17);
            this.label_note.TabIndex = 12;
            this.label_note.Text = "Chú thích thêm ( nếu có):";
            // 
            // textBox_gift
            // 
            this.textBox_gift.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_gift.Location = new System.Drawing.Point(14, 52);
            this.textBox_gift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_gift.Name = "textBox_gift";
            this.textBox_gift.Size = new System.Drawing.Size(502, 22);
            this.textBox_gift.TabIndex = 11;
            // 
            // label_gift
            // 
            this.label_gift.AutoSize = true;
            this.label_gift.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gift.Location = new System.Drawing.Point(9, 31);
            this.label_gift.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gift.Name = "label_gift";
            this.label_gift.Size = new System.Drawing.Size(127, 17);
            this.label_gift.TabIndex = 10;
            this.label_gift.Text = "Tên quà tặng kèm:";
            // 
            // groupBox_sale
            // 
            this.groupBox_sale.Controls.Add(this.label1);
            this.groupBox_sale.Controls.Add(this.numericUpDown_Condition_Quantity);
            this.groupBox_sale.Controls.Add(this.label_Condition_quantity);
            this.groupBox_sale.Controls.Add(this.numericUpDown_Condition_price);
            this.groupBox_sale.Controls.Add(this.label_Condition_price);
            this.groupBox_sale.Controls.Add(this.checkBox_priceCondition);
            this.groupBox_sale.Controls.Add(this.numericUpDown_priceReduced);
            this.groupBox_sale.Controls.Add(this.comboBox_priceMethod);
            this.groupBox_sale.Controls.Add(this.label_priceReduced);
            this.groupBox_sale.Controls.Add(this.label_priceMethod);
            this.groupBox_sale.Location = new System.Drawing.Point(28, 172);
            this.groupBox_sale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_sale.Name = "groupBox_sale";
            this.groupBox_sale.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_sale.Size = new System.Drawing.Size(852, 310);
            this.groupBox_sale.TabIndex = 0;
            this.groupBox_sale.TabStop = false;
            this.groupBox_sale.Text = "Giảm giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "VND";
            // 
            // numericUpDown_Condition_Quantity
            // 
            this.numericUpDown_Condition_Quantity.Enabled = false;
            this.numericUpDown_Condition_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Condition_Quantity.Location = new System.Drawing.Point(14, 260);
            this.numericUpDown_Condition_Quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Condition_Quantity.Name = "numericUpDown_Condition_Quantity";
            this.numericUpDown_Condition_Quantity.Size = new System.Drawing.Size(188, 22);
            this.numericUpDown_Condition_Quantity.TabIndex = 17;
            this.numericUpDown_Condition_Quantity.Click += new System.EventHandler(this.numericUpDown_Condition_Quantity_Click);
            // 
            // label_Condition_quantity
            // 
            this.label_Condition_quantity.AutoSize = true;
            this.label_Condition_quantity.Enabled = false;
            this.label_Condition_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Condition_quantity.Location = new System.Drawing.Point(9, 239);
            this.label_Condition_quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Condition_quantity.Name = "label_Condition_quantity";
            this.label_Condition_quantity.Size = new System.Drawing.Size(128, 17);
            this.label_Condition_quantity.TabIndex = 16;
            this.label_Condition_quantity.Text = "Số lượng mua trên:";
            // 
            // numericUpDown_Condition_price
            // 
            this.numericUpDown_Condition_price.Enabled = false;
            this.numericUpDown_Condition_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Condition_price.Location = new System.Drawing.Point(14, 210);
            this.numericUpDown_Condition_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Condition_price.Name = "numericUpDown_Condition_price";
            this.numericUpDown_Condition_price.Size = new System.Drawing.Size(188, 22);
            this.numericUpDown_Condition_price.TabIndex = 15;
            this.numericUpDown_Condition_price.Click += new System.EventHandler(this.numericUpDown_Condition_price_Click);
            // 
            // label_Condition_price
            // 
            this.label_Condition_price.AutoSize = true;
            this.label_Condition_price.Enabled = false;
            this.label_Condition_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Condition_price.Location = new System.Drawing.Point(9, 190);
            this.label_Condition_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Condition_price.Name = "label_Condition_price";
            this.label_Condition_price.Size = new System.Drawing.Size(126, 17);
            this.label_Condition_price.TabIndex = 14;
            this.label_Condition_price.Text = "Giá mặt hàng trên:";
            // 
            // checkBox_priceCondition
            // 
            this.checkBox_priceCondition.AutoSize = true;
            this.checkBox_priceCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_priceCondition.Location = new System.Drawing.Point(14, 149);
            this.checkBox_priceCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_priceCondition.Name = "checkBox_priceCondition";
            this.checkBox_priceCondition.Size = new System.Drawing.Size(146, 21);
            this.checkBox_priceCondition.TabIndex = 13;
            this.checkBox_priceCondition.Text = "Điều kiện giảm giá";
            this.checkBox_priceCondition.UseVisualStyleBackColor = true;
            this.checkBox_priceCondition.CheckStateChanged += new System.EventHandler(this.checkBox_priceCondition_CheckStateChanged);
            // 
            // numericUpDown_priceReduced
            // 
            this.numericUpDown_priceReduced.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_priceReduced.Location = new System.Drawing.Point(14, 102);
            this.numericUpDown_priceReduced.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_priceReduced.Name = "numericUpDown_priceReduced";
            this.numericUpDown_priceReduced.Size = new System.Drawing.Size(188, 22);
            this.numericUpDown_priceReduced.TabIndex = 12;
            this.numericUpDown_priceReduced.Click += new System.EventHandler(this.numericUpDown_priceReduced_Click);
            // 
            // comboBox_priceMethod
            // 
            this.comboBox_priceMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_priceMethod.FormattingEnabled = true;
            this.comboBox_priceMethod.Items.AddRange(new object[] {
            "Giảm theo số",
            "Giảm theo phần trăm"});
            this.comboBox_priceMethod.Location = new System.Drawing.Point(14, 52);
            this.comboBox_priceMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_priceMethod.Name = "comboBox_priceMethod";
            this.comboBox_priceMethod.Size = new System.Drawing.Size(224, 24);
            this.comboBox_priceMethod.TabIndex = 11;
            this.comboBox_priceMethod.Text = "Giảm theo phần trăm";
            this.comboBox_priceMethod.TextChanged += new System.EventHandler(this.comboBox_priceMethod_TextChanged);
            // 
            // label_priceReduced
            // 
            this.label_priceReduced.AutoSize = true;
            this.label_priceReduced.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_priceReduced.Location = new System.Drawing.Point(9, 81);
            this.label_priceReduced.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_priceReduced.Name = "label_priceReduced";
            this.label_priceReduced.Size = new System.Drawing.Size(137, 17);
            this.label_priceReduced.TabIndex = 10;
            this.label_priceReduced.Text = "Phần trăm giảm (%):";
            // 
            // label_priceMethod
            // 
            this.label_priceMethod.AutoSize = true;
            this.label_priceMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_priceMethod.Location = new System.Drawing.Point(9, 32);
            this.label_priceMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_priceMethod.Name = "label_priceMethod";
            this.label_priceMethod.Size = new System.Drawing.Size(97, 17);
            this.label_priceMethod.TabIndex = 10;
            this.label_priceMethod.Text = "Kiểu giảm giá:";
            // 
            // button_quit
            // 
            this.button_quit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quit.Location = new System.Drawing.Point(790, 792);
            this.button_quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(112, 28);
            this.button_quit.TabIndex = 2;
            this.button_quit.Text = "Thoát";
            this.button_quit.UseVisualStyleBackColor = false;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(632, 792);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(112, 28);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Lưu";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dataGridView_manager
            // 
            this.dataGridView_manager.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_manager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_manager.Location = new System.Drawing.Point(934, 28);
            this.dataGridView_manager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_manager.Name = "dataGridView_manager";
            this.dataGridView_manager.ReadOnly = true;
            this.dataGridView_manager.RowHeadersWidth = 51;
            this.dataGridView_manager.Size = new System.Drawing.Size(12, 12);
            this.dataGridView_manager.TabIndex = 4;
            // 
            // Sale_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(961, 832);
            this.Controls.Add(this.dataGridView_manager);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.groupBox_detail);
            this.Controls.Add(this.groupBox_general);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sale_manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ưu đãi";
            this.groupBox_general.ResumeLayout(false);
            this.groupBox_general.PerformLayout();
            this.groupBox_detail.ResumeLayout(false);
            this.groupBox_gift.ResumeLayout(false);
            this.groupBox_gift.PerformLayout();
            this.groupBox_sale.ResumeLayout(false);
            this.groupBox_sale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Condition_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Condition_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_priceReduced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_general;
        public System.Windows.Forms.Label label_saleObj;
        public System.Windows.Forms.TextBox textBox_saleName;
        public System.Windows.Forms.Label label_saleName;
        public System.Windows.Forms.GroupBox groupBox_detail;
        public System.Windows.Forms.Button button_quit;
        public System.Windows.Forms.Button button_save;
        public System.Windows.Forms.ComboBox comboBox_saleObj;
        public System.Windows.Forms.ComboBox comboBox_saleMethod;
        public System.Windows.Forms.Label label_saleMethod;
        public System.Windows.Forms.ComboBox comboBox_saleCondition;
        public System.Windows.Forms.Label label_saleCondition;
        public System.Windows.Forms.ComboBox comboBox_Condition;
        public System.Windows.Forms.Label label_Condition;
        public System.Windows.Forms.GroupBox groupBox_gift;
        public System.Windows.Forms.TextBox textBox_note;
        public System.Windows.Forms.Label label_note;
        public System.Windows.Forms.TextBox textBox_gift;
        public System.Windows.Forms.Label label_gift;
        public System.Windows.Forms.GroupBox groupBox_sale;
        public System.Windows.Forms.NumericUpDown numericUpDown_priceReduced;
        public System.Windows.Forms.ComboBox comboBox_priceMethod;
        public System.Windows.Forms.Label label_priceReduced;
        public System.Windows.Forms.Label label_priceMethod;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numericUpDown_Condition_Quantity;
        public System.Windows.Forms.Label label_Condition_quantity;
        public System.Windows.Forms.NumericUpDown numericUpDown_Condition_price;
        public System.Windows.Forms.Label label_Condition_price;
        public System.Windows.Forms.CheckBox checkBox_priceCondition;
        public System.Windows.Forms.Label label_startDate;
        public System.Windows.Forms.DateTimePicker dateTimePicker_startDate;
        public System.Windows.Forms.DateTimePicker dateTimePicker_endDate;
        public System.Windows.Forms.Label label_endDate;
        public System.Windows.Forms.CheckBox checkBox_autoDelete;
        private System.Windows.Forms.DataGridView dataGridView_manager;
    }
}