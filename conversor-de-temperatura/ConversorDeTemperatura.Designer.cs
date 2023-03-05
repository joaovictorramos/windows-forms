namespace Temperatura
{
    partial class ConversorDeTemperatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.radInputCelsius = new System.Windows.Forms.RadioButton();
            this.radInputFahrenheit = new System.Windows.Forms.RadioButton();
            this.radInputKelvin = new System.Windows.Forms.RadioButton();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.radOutputKelvin = new System.Windows.Forms.RadioButton();
            this.radOutputFahrenheit = new System.Windows.Forms.RadioButton();
            this.radOutputCelsius = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(187, 39);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(379, 32);
            this.txtValue.TabIndex = 1;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // radInputCelsius
            // 
            this.radInputCelsius.AutoSize = true;
            this.radInputCelsius.Checked = true;
            this.radInputCelsius.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInputCelsius.Location = new System.Drawing.Point(68, 22);
            this.radInputCelsius.Name = "radInputCelsius";
            this.radInputCelsius.Size = new System.Drawing.Size(80, 25);
            this.radInputCelsius.TabIndex = 2;
            this.radInputCelsius.TabStop = true;
            this.radInputCelsius.Text = "Celsius";
            this.radInputCelsius.UseVisualStyleBackColor = true;
            this.radInputCelsius.CheckedChanged += new System.EventHandler(this.radInputCelsius_CheckedChanged);
            // 
            // radInputFahrenheit
            // 
            this.radInputFahrenheit.AutoSize = true;
            this.radInputFahrenheit.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInputFahrenheit.Location = new System.Drawing.Point(68, 84);
            this.radInputFahrenheit.Name = "radInputFahrenheit";
            this.radInputFahrenheit.Size = new System.Drawing.Size(102, 25);
            this.radInputFahrenheit.TabIndex = 3;
            this.radInputFahrenheit.Text = "Fahrenheit";
            this.radInputFahrenheit.UseVisualStyleBackColor = true;
            this.radInputFahrenheit.CheckedChanged += new System.EventHandler(this.radInputFahrenheit_CheckedChanged);
            // 
            // radInputKelvin
            // 
            this.radInputKelvin.AutoSize = true;
            this.radInputKelvin.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInputKelvin.Location = new System.Drawing.Point(68, 53);
            this.radInputKelvin.Name = "radInputKelvin";
            this.radInputKelvin.Size = new System.Drawing.Size(71, 25);
            this.radInputKelvin.TabIndex = 4;
            this.radInputKelvin.Text = "Kelvin";
            this.radInputKelvin.UseVisualStyleBackColor = true;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.radInputKelvin);
            this.grpInput.Controls.Add(this.radInputFahrenheit);
            this.grpInput.Controls.Add(this.radInputCelsius);
            this.grpInput.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(67, 105);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(225, 122);
            this.grpInput.TabIndex = 5;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Entrada";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.radOutputKelvin);
            this.grpOutput.Controls.Add(this.radOutputFahrenheit);
            this.grpOutput.Controls.Add(this.radOutputCelsius);
            this.grpOutput.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutput.Location = new System.Drawing.Point(341, 105);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(225, 122);
            this.grpOutput.TabIndex = 6;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Saída";
            // 
            // radOutputKelvin
            // 
            this.radOutputKelvin.AutoSize = true;
            this.radOutputKelvin.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOutputKelvin.Location = new System.Drawing.Point(68, 53);
            this.radOutputKelvin.Name = "radOutputKelvin";
            this.radOutputKelvin.Size = new System.Drawing.Size(71, 25);
            this.radOutputKelvin.TabIndex = 4;
            this.radOutputKelvin.Text = "Kelvin";
            this.radOutputKelvin.UseVisualStyleBackColor = true;
            // 
            // radOutputFahrenheit
            // 
            this.radOutputFahrenheit.AutoSize = true;
            this.radOutputFahrenheit.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOutputFahrenheit.Location = new System.Drawing.Point(68, 84);
            this.radOutputFahrenheit.Name = "radOutputFahrenheit";
            this.radOutputFahrenheit.Size = new System.Drawing.Size(102, 25);
            this.radOutputFahrenheit.TabIndex = 3;
            this.radOutputFahrenheit.Text = "Fahrenheit";
            this.radOutputFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radOutputCelsius
            // 
            this.radOutputCelsius.AutoSize = true;
            this.radOutputCelsius.Checked = true;
            this.radOutputCelsius.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOutputCelsius.Location = new System.Drawing.Point(68, 22);
            this.radOutputCelsius.Name = "radOutputCelsius";
            this.radOutputCelsius.Size = new System.Drawing.Size(80, 25);
            this.radOutputCelsius.TabIndex = 2;
            this.radOutputCelsius.TabStop = true;
            this.radOutputCelsius.Text = "Celsius";
            this.radOutputCelsius.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultado:";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(187, 265);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(379, 32);
            this.txtResult.TabIndex = 8;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(147, 327);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(102, 32);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(387, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 395);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.RadioButton radInputCelsius;
        private System.Windows.Forms.RadioButton radInputFahrenheit;
        private System.Windows.Forms.RadioButton radInputKelvin;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.RadioButton radOutputKelvin;
        private System.Windows.Forms.RadioButton radOutputFahrenheit;
        private System.Windows.Forms.RadioButton radOutputCelsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
    }
}

