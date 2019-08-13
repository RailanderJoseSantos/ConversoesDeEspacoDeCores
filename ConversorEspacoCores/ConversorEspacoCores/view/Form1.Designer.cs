namespace ConversorEspacoCores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label_H_HSV;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_rgbParaTodos = new System.Windows.Forms.Button();
            this.button_xyzParaRgb = new System.Windows.Forms.Button();
            this.label_azul = new System.Windows.Forms.Label();
            this.textBox_azul = new System.Windows.Forms.TextBox();
            this.label_verde = new System.Windows.Forms.Label();
            this.textBox_verde = new System.Windows.Forms.TextBox();
            this.label_vermelho = new System.Windows.Forms.Label();
            this.textBox_vermelho = new System.Windows.Forms.TextBox();
            this.label_V_HSV = new System.Windows.Forms.Label();
            this.textBox_V_HSV = new System.Windows.Forms.TextBox();
            this.label_S_HSV = new System.Windows.Forms.Label();
            this.textBox_S_HSV = new System.Windows.Forms.TextBox();
            this.textBox_H_HSV = new System.Windows.Forms.TextBox();
            this.textBox_K_cmyk = new System.Windows.Forms.TextBox();
            this.label_K_cmyk = new System.Windows.Forms.Label();
            this.textBox_Y_cmyk = new System.Windows.Forms.TextBox();
            this.label_Y_cmyk = new System.Windows.Forms.Label();
            this.textBox_M_cmyk = new System.Windows.Forms.TextBox();
            this.label_M_cmyk = new System.Windows.Forms.Label();
            this.textBox_C_CMYK = new System.Windows.Forms.TextBox();
            this.label_C_cmyk = new System.Windows.Forms.Label();
            this.txt_cinzaCoef = new System.Windows.Forms.TextBox();
            this.label_cinzaCoef = new System.Windows.Forms.Label();
            this.txt_cinzaMedia = new System.Windows.Forms.TextBox();
            this.label_cinzaMedia = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.textBox_Z = new System.Windows.Forms.TextBox();
            this.label_Y = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.button_limpa = new System.Windows.Forms.Button();
            label_H_HSV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_H_HSV
            // 
            label_H_HSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label_H_HSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_H_HSV.ForeColor = System.Drawing.Color.Black;
            label_H_HSV.Location = new System.Drawing.Point(12, 145);
            label_H_HSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label_H_HSV.Name = "label_H_HSV";
            label_H_HSV.Size = new System.Drawing.Size(32, 26);
            label_H_HSV.TabIndex = 159;
            label_H_HSV.Text = "H:";
            // 
            // button_rgbParaTodos
            // 
            this.button_rgbParaTodos.BackColor = System.Drawing.Color.Black;
            this.button_rgbParaTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rgbParaTodos.ForeColor = System.Drawing.Color.White;
            this.button_rgbParaTodos.Location = new System.Drawing.Point(11, 331);
            this.button_rgbParaTodos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_rgbParaTodos.Name = "button_rgbParaTodos";
            this.button_rgbParaTodos.Size = new System.Drawing.Size(191, 46);
            this.button_rgbParaTodos.TabIndex = 0;
            this.button_rgbParaTodos.Text = "De RGB para todos";
            this.button_rgbParaTodos.UseVisualStyleBackColor = false;
            this.button_rgbParaTodos.Click += new System.EventHandler(this.Button_rgbParaTodos_Click);
            // 
            // button_xyzParaRgb
            // 
            this.button_xyzParaRgb.BackColor = System.Drawing.Color.Black;
            this.button_xyzParaRgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xyzParaRgb.ForeColor = System.Drawing.Color.White;
            this.button_xyzParaRgb.Location = new System.Drawing.Point(319, 331);
            this.button_xyzParaRgb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_xyzParaRgb.Name = "button_xyzParaRgb";
            this.button_xyzParaRgb.Size = new System.Drawing.Size(192, 46);
            this.button_xyzParaRgb.TabIndex = 1;
            this.button_xyzParaRgb.Text = "De XYZ para RBG";
            this.button_xyzParaRgb.UseVisualStyleBackColor = false;
            this.button_xyzParaRgb.Click += new System.EventHandler(this.Button_xyzParaRgb_Click);
            // 
            // label_azul
            // 
            this.label_azul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_azul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_azul.ForeColor = System.Drawing.Color.Blue;
            this.label_azul.Location = new System.Drawing.Point(258, 58);
            this.label_azul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_azul.Name = "label_azul";
            this.label_azul.Size = new System.Drawing.Size(32, 26);
            this.label_azul.TabIndex = 35;
            this.label_azul.Text = "B:";
            // 
            // textBox_azul
            // 
            this.textBox_azul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_azul.Location = new System.Drawing.Point(296, 58);
            this.textBox_azul.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_azul.Name = "textBox_azul";
            this.textBox_azul.Size = new System.Drawing.Size(78, 26);
            this.textBox_azul.TabIndex = 34;
            this.textBox_azul.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_azul_MouseClick);
            this.textBox_azul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_azul_KeyPress);
            // 
            // label_verde
            // 
            this.label_verde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_verde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_verde.ForeColor = System.Drawing.Color.Green;
            this.label_verde.Location = new System.Drawing.Point(134, 58);
            this.label_verde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_verde.Name = "label_verde";
            this.label_verde.Size = new System.Drawing.Size(32, 26);
            this.label_verde.TabIndex = 33;
            this.label_verde.Text = "G:";
            // 
            // textBox_verde
            // 
            this.textBox_verde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox_verde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_verde.Location = new System.Drawing.Point(173, 58);
            this.textBox_verde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_verde.Name = "textBox_verde";
            this.textBox_verde.Size = new System.Drawing.Size(78, 26);
            this.textBox_verde.TabIndex = 32;
            this.textBox_verde.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_verde_MouseClick);
            this.textBox_verde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_verde_KeyPress);
            // 
            // label_vermelho
            // 
            this.label_vermelho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_vermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vermelho.ForeColor = System.Drawing.Color.Red;
            this.label_vermelho.Location = new System.Drawing.Point(12, 58);
            this.label_vermelho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_vermelho.Name = "label_vermelho";
            this.label_vermelho.Size = new System.Drawing.Size(32, 26);
            this.label_vermelho.TabIndex = 29;
            this.label_vermelho.Text = "R:";
            // 
            // textBox_vermelho
            // 
            this.textBox_vermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_vermelho.Location = new System.Drawing.Point(50, 58);
            this.textBox_vermelho.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_vermelho.Name = "textBox_vermelho";
            this.textBox_vermelho.Size = new System.Drawing.Size(78, 26);
            this.textBox_vermelho.TabIndex = 28;
            this.textBox_vermelho.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_vermelho_MouseClick);
            this.textBox_vermelho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_vermelho_KeyPress);
            // 
            // label_V_HSV
            // 
            this.label_V_HSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_V_HSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_V_HSV.ForeColor = System.Drawing.Color.Black;
            this.label_V_HSV.Location = new System.Drawing.Point(258, 145);
            this.label_V_HSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_V_HSV.Name = "label_V_HSV";
            this.label_V_HSV.Size = new System.Drawing.Size(32, 26);
            this.label_V_HSV.TabIndex = 164;
            this.label_V_HSV.Text = "V:";
            // 
            // textBox_V_HSV
            // 
            this.textBox_V_HSV.AcceptsTab = true;
            this.textBox_V_HSV.Enabled = false;
            this.textBox_V_HSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_V_HSV.Location = new System.Drawing.Point(296, 145);
            this.textBox_V_HSV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_V_HSV.Name = "textBox_V_HSV";
            this.textBox_V_HSV.Size = new System.Drawing.Size(78, 26);
            this.textBox_V_HSV.TabIndex = 163;
            // 
            // label_S_HSV
            // 
            this.label_S_HSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_S_HSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_S_HSV.ForeColor = System.Drawing.Color.Black;
            this.label_S_HSV.Location = new System.Drawing.Point(134, 145);
            this.label_S_HSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_S_HSV.Name = "label_S_HSV";
            this.label_S_HSV.Size = new System.Drawing.Size(32, 26);
            this.label_S_HSV.TabIndex = 162;
            this.label_S_HSV.Text = "S:";
            // 
            // textBox_S_HSV
            // 
            this.textBox_S_HSV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textBox_S_HSV.Enabled = false;
            this.textBox_S_HSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_S_HSV.Location = new System.Drawing.Point(173, 145);
            this.textBox_S_HSV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_S_HSV.Name = "textBox_S_HSV";
            this.textBox_S_HSV.Size = new System.Drawing.Size(78, 26);
            this.textBox_S_HSV.TabIndex = 161;
            // 
            // textBox_H_HSV
            // 
            this.textBox_H_HSV.Enabled = false;
            this.textBox_H_HSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_H_HSV.Location = new System.Drawing.Point(50, 145);
            this.textBox_H_HSV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_H_HSV.Name = "textBox_H_HSV";
            this.textBox_H_HSV.Size = new System.Drawing.Size(78, 26);
            this.textBox_H_HSV.TabIndex = 158;
            // 
            // textBox_K_cmyk
            // 
            this.textBox_K_cmyk.Enabled = false;
            this.textBox_K_cmyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_K_cmyk.Location = new System.Drawing.Point(432, 12);
            this.textBox_K_cmyk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_K_cmyk.Name = "textBox_K_cmyk";
            this.textBox_K_cmyk.Size = new System.Drawing.Size(78, 26);
            this.textBox_K_cmyk.TabIndex = 157;
            // 
            // label_K_cmyk
            // 
            this.label_K_cmyk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_K_cmyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_K_cmyk.ForeColor = System.Drawing.Color.Black;
            this.label_K_cmyk.Location = new System.Drawing.Point(394, 12);
            this.label_K_cmyk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_K_cmyk.Name = "label_K_cmyk";
            this.label_K_cmyk.Size = new System.Drawing.Size(32, 26);
            this.label_K_cmyk.TabIndex = 156;
            this.label_K_cmyk.Text = "K:";
            // 
            // textBox_Y_cmyk
            // 
            this.textBox_Y_cmyk.Enabled = false;
            this.textBox_Y_cmyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Y_cmyk.Location = new System.Drawing.Point(296, 12);
            this.textBox_Y_cmyk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Y_cmyk.Name = "textBox_Y_cmyk";
            this.textBox_Y_cmyk.Size = new System.Drawing.Size(78, 26);
            this.textBox_Y_cmyk.TabIndex = 155;
            // 
            // label_Y_cmyk
            // 
            this.label_Y_cmyk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Y_cmyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Y_cmyk.ForeColor = System.Drawing.Color.Yellow;
            this.label_Y_cmyk.Location = new System.Drawing.Point(258, 12);
            this.label_Y_cmyk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Y_cmyk.Name = "label_Y_cmyk";
            this.label_Y_cmyk.Size = new System.Drawing.Size(32, 26);
            this.label_Y_cmyk.TabIndex = 154;
            this.label_Y_cmyk.Text = "Y:";
            // 
            // textBox_M_cmyk
            // 
            this.textBox_M_cmyk.Enabled = false;
            this.textBox_M_cmyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_M_cmyk.Location = new System.Drawing.Point(173, 12);
            this.textBox_M_cmyk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_M_cmyk.Name = "textBox_M_cmyk";
            this.textBox_M_cmyk.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_M_cmyk.Size = new System.Drawing.Size(78, 26);
            this.textBox_M_cmyk.TabIndex = 153;
            // 
            // label_M_cmyk
            // 
            this.label_M_cmyk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_M_cmyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_M_cmyk.ForeColor = System.Drawing.Color.Magenta;
            this.label_M_cmyk.Location = new System.Drawing.Point(134, 12);
            this.label_M_cmyk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_M_cmyk.Name = "label_M_cmyk";
            this.label_M_cmyk.Size = new System.Drawing.Size(32, 26);
            this.label_M_cmyk.TabIndex = 152;
            this.label_M_cmyk.Text = "M:";
            // 
            // textBox_C_CMYK
            // 
            this.textBox_C_CMYK.Enabled = false;
            this.textBox_C_CMYK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_C_CMYK.Location = new System.Drawing.Point(50, 12);
            this.textBox_C_CMYK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_C_CMYK.Name = "textBox_C_CMYK";
            this.textBox_C_CMYK.Size = new System.Drawing.Size(78, 26);
            this.textBox_C_CMYK.TabIndex = 151;
            // 
            // label_C_cmyk
            // 
            this.label_C_cmyk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_C_cmyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_C_cmyk.ForeColor = System.Drawing.Color.Cyan;
            this.label_C_cmyk.Location = new System.Drawing.Point(8, 12);
            this.label_C_cmyk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_C_cmyk.Name = "label_C_cmyk";
            this.label_C_cmyk.Size = new System.Drawing.Size(32, 26);
            this.label_C_cmyk.TabIndex = 149;
            this.label_C_cmyk.Text = "C:";
            // 
            // txt_cinzaCoef
            // 
            this.txt_cinzaCoef.Enabled = false;
            this.txt_cinzaCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cinzaCoef.Location = new System.Drawing.Point(186, 194);
            this.txt_cinzaCoef.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_cinzaCoef.Name = "txt_cinzaCoef";
            this.txt_cinzaCoef.Size = new System.Drawing.Size(189, 26);
            this.txt_cinzaCoef.TabIndex = 146;
            // 
            // label_cinzaCoef
            // 
            this.label_cinzaCoef.AutoSize = true;
            this.label_cinzaCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cinzaCoef.Location = new System.Drawing.Point(12, 194);
            this.label_cinzaCoef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cinzaCoef.Name = "label_cinzaCoef";
            this.label_cinzaCoef.Size = new System.Drawing.Size(161, 24);
            this.label_cinzaCoef.TabIndex = 145;
            this.label_cinzaCoef.Text = "Cinza Coeficiente:";
            // 
            // txt_cinzaMedia
            // 
            this.txt_cinzaMedia.Enabled = false;
            this.txt_cinzaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cinzaMedia.Location = new System.Drawing.Point(186, 236);
            this.txt_cinzaMedia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_cinzaMedia.Name = "txt_cinzaMedia";
            this.txt_cinzaMedia.Size = new System.Drawing.Size(189, 26);
            this.txt_cinzaMedia.TabIndex = 142;
            // 
            // label_cinzaMedia
            // 
            this.label_cinzaMedia.AutoSize = true;
            this.label_cinzaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cinzaMedia.Location = new System.Drawing.Point(49, 238);
            this.label_cinzaMedia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cinzaMedia.Name = "label_cinzaMedia";
            this.label_cinzaMedia.Size = new System.Drawing.Size(119, 24);
            this.label_cinzaMedia.TabIndex = 141;
            this.label_cinzaMedia.Text = "Cinza Média:";
            // 
            // label_Z
            // 
            this.label_Z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Z.ForeColor = System.Drawing.Color.Black;
            this.label_Z.Location = new System.Drawing.Point(258, 102);
            this.label_Z.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(32, 26);
            this.label_Z.TabIndex = 140;
            this.label_Z.Text = "Z:";
            // 
            // textBox_Z
            // 
            this.textBox_Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Z.Location = new System.Drawing.Point(296, 102);
            this.textBox_Z.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Z.Name = "textBox_Z";
            this.textBox_Z.Size = new System.Drawing.Size(78, 26);
            this.textBox_Z.TabIndex = 139;
            this.textBox_Z.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_Z_MouseClick);
            this.textBox_Z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Z_KeyPress);
            // 
            // label_Y
            // 
            this.label_Y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Y.ForeColor = System.Drawing.Color.Black;
            this.label_Y.Location = new System.Drawing.Point(134, 102);
            this.label_Y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(32, 26);
            this.label_Y.TabIndex = 138;
            this.label_Y.Text = "Y:";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Y.Location = new System.Drawing.Point(173, 102);
            this.textBox_Y.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(78, 26);
            this.textBox_Y.TabIndex = 137;
            this.textBox_Y.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_Y_MouseClick);
            this.textBox_Y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Y_KeyPress);
            // 
            // label_X
            // 
            this.label_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.ForeColor = System.Drawing.Color.Black;
            this.label_X.Location = new System.Drawing.Point(12, 102);
            this.label_X.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(32, 26);
            this.label_X.TabIndex = 135;
            this.label_X.Text = "X:";
            // 
            // textBox_X
            // 
            this.textBox_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_X.Location = new System.Drawing.Point(50, 102);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(78, 26);
            this.textBox_X.TabIndex = 134;
            this.textBox_X.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_X_MouseClick);
            this.textBox_X.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_X_KeyPress);
            // 
            // button_limpa
            // 
            this.button_limpa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_limpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpa.ForeColor = System.Drawing.Color.White;
            this.button_limpa.Location = new System.Drawing.Point(215, 331);
            this.button_limpa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_limpa.Name = "button_limpa";
            this.button_limpa.Size = new System.Drawing.Size(85, 46);
            this.button_limpa.TabIndex = 165;
            this.button_limpa.Text = "Limpa";
            this.button_limpa.UseVisualStyleBackColor = false;
            this.button_limpa.Click += new System.EventHandler(this.Button_limpa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(532, 395);
            this.Controls.Add(this.button_limpa);
            this.Controls.Add(this.label_V_HSV);
            this.Controls.Add(this.textBox_V_HSV);
            this.Controls.Add(this.label_S_HSV);
            this.Controls.Add(this.textBox_S_HSV);
            this.Controls.Add(label_H_HSV);
            this.Controls.Add(this.textBox_H_HSV);
            this.Controls.Add(this.textBox_K_cmyk);
            this.Controls.Add(this.label_K_cmyk);
            this.Controls.Add(this.textBox_Y_cmyk);
            this.Controls.Add(this.label_Y_cmyk);
            this.Controls.Add(this.textBox_M_cmyk);
            this.Controls.Add(this.label_M_cmyk);
            this.Controls.Add(this.textBox_C_CMYK);
            this.Controls.Add(this.label_C_cmyk);
            this.Controls.Add(this.txt_cinzaCoef);
            this.Controls.Add(this.label_cinzaCoef);
            this.Controls.Add(this.txt_cinzaMedia);
            this.Controls.Add(this.label_cinzaMedia);
            this.Controls.Add(this.label_Z);
            this.Controls.Add(this.textBox_Z);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.textBox_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.textBox_X);
            this.Controls.Add(this.label_azul);
            this.Controls.Add(this.textBox_azul);
            this.Controls.Add(this.label_verde);
            this.Controls.Add(this.textBox_verde);
            this.Controls.Add(this.label_vermelho);
            this.Controls.Add(this.textBox_vermelho);
            this.Controls.Add(this.button_xyzParaRgb);
            this.Controls.Add(this.button_rgbParaTodos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Conversor de Escala de Cores ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_rgbParaTodos;
        private System.Windows.Forms.Button button_xyzParaRgb;
        internal System.Windows.Forms.Label label_azul;
        internal System.Windows.Forms.TextBox textBox_azul;
        internal System.Windows.Forms.Label label_verde;
        internal System.Windows.Forms.TextBox textBox_verde;
        internal System.Windows.Forms.Label label_vermelho;
        internal System.Windows.Forms.TextBox textBox_vermelho;
        internal System.Windows.Forms.Label label_V_HSV;
        internal System.Windows.Forms.TextBox textBox_V_HSV;
        internal System.Windows.Forms.Label label_S_HSV;
        internal System.Windows.Forms.TextBox textBox_S_HSV;
        internal System.Windows.Forms.TextBox textBox_H_HSV;
        internal System.Windows.Forms.TextBox textBox_K_cmyk;
        internal System.Windows.Forms.Label label_K_cmyk;
        internal System.Windows.Forms.TextBox textBox_Y_cmyk;
        internal System.Windows.Forms.Label label_Y_cmyk;
        internal System.Windows.Forms.TextBox textBox_M_cmyk;
        internal System.Windows.Forms.Label label_M_cmyk;
        internal System.Windows.Forms.TextBox textBox_C_CMYK;
        internal System.Windows.Forms.Label label_C_cmyk;
        internal System.Windows.Forms.TextBox txt_cinzaCoef;
        private System.Windows.Forms.Label label_cinzaCoef;
        internal System.Windows.Forms.TextBox txt_cinzaMedia;
        private System.Windows.Forms.Label label_cinzaMedia;
        internal System.Windows.Forms.Label label_Z;
        internal System.Windows.Forms.TextBox textBox_Z;
        internal System.Windows.Forms.Label label_Y;
        internal System.Windows.Forms.TextBox textBox_Y;
        internal System.Windows.Forms.Label label_X;
        internal System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Button button_limpa;
    }
}

