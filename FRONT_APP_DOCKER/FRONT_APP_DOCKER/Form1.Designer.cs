namespace FRONT_APP_DOCKER
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbContainers = new System.Windows.Forms.GroupBox();
            this.btnDeleteImageAll = new System.Windows.Forms.Button();
            this.btnDeleteContainer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCreateContainer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblContainers = new System.Windows.Forms.Label();
            this.btnListContainers = new System.Windows.Forms.Button();
            this.gbImages = new System.Windows.Forms.GroupBox();
            this.btnDeleteImagesAll = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCreateImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblImages = new System.Windows.Forms.Label();
            this.btnListImages = new System.Windows.Forms.Button();
            this.gbContainers.SuspendLayout();
            this.gbImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContainers
            // 
            this.gbContainers.Controls.Add(this.btnDeleteImageAll);
            this.gbContainers.Controls.Add(this.btnDeleteContainer);
            this.gbContainers.Controls.Add(this.label3);
            this.gbContainers.Controls.Add(this.txtId);
            this.gbContainers.Controls.Add(this.btnCreateContainer);
            this.gbContainers.Controls.Add(this.label2);
            this.gbContainers.Controls.Add(this.label1);
            this.gbContainers.Controls.Add(this.txtName);
            this.gbContainers.Controls.Add(this.txtPort);
            this.gbContainers.Controls.Add(this.lblContainers);
            this.gbContainers.Controls.Add(this.btnListContainers);
            this.gbContainers.Location = new System.Drawing.Point(9, 10);
            this.gbContainers.Name = "gbContainers";
            this.gbContainers.Size = new System.Drawing.Size(392, 458);
            this.gbContainers.TabIndex = 0;
            this.gbContainers.TabStop = false;
            this.gbContainers.Text = "Containers";
            // 
            // btnDeleteImageAll
            // 
            this.btnDeleteImageAll.Location = new System.Drawing.Point(228, 22);
            this.btnDeleteImageAll.Name = "btnDeleteImageAll";
            this.btnDeleteImageAll.Size = new System.Drawing.Size(158, 23);
            this.btnDeleteImageAll.TabIndex = 10;
            this.btnDeleteImageAll.Text = "Deletar Todos Container";
            this.btnDeleteImageAll.UseVisualStyleBackColor = true;
            this.btnDeleteImageAll.Click += new System.EventHandler(this.btnDeleteImageAll_Click);
            // 
            // btnDeleteContainer
            // 
            this.btnDeleteContainer.Location = new System.Drawing.Point(153, 428);
            this.btnDeleteContainer.Name = "btnDeleteContainer";
            this.btnDeleteContainer.Size = new System.Drawing.Size(133, 23);
            this.btnDeleteContainer.TabIndex = 9;
            this.btnDeleteContainer.Text = "Deletar Container";
            this.btnDeleteContainer.UseVisualStyleBackColor = true;
            this.btnDeleteContainer.Click += new System.EventHandler(this.btnDeleteContainer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 429);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(115, 23);
            this.txtId.TabIndex = 7;
            // 
            // btnCreateContainer
            // 
            this.btnCreateContainer.Location = new System.Drawing.Point(6, 372);
            this.btnCreateContainer.Name = "btnCreateContainer";
            this.btnCreateContainer.Size = new System.Drawing.Size(133, 23);
            this.btnCreateContainer.TabIndex = 6;
            this.btnCreateContainer.Text = "Criar Container";
            this.btnCreateContainer.UseVisualStyleBackColor = true;
            this.btnCreateContainer.Click += new System.EventHandler(this.btnCreateContainer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 329);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 23);
            this.txtName.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(6, 329);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(115, 23);
            this.txtPort.TabIndex = 2;
            // 
            // lblContainers
            // 
            this.lblContainers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblContainers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContainers.Location = new System.Drawing.Point(6, 60);
            this.lblContainers.Name = "lblContainers";
            this.lblContainers.Size = new System.Drawing.Size(380, 234);
            this.lblContainers.TabIndex = 1;
            this.lblContainers.Text = "label1";
            // 
            // btnListContainers
            // 
            this.btnListContainers.Location = new System.Drawing.Point(6, 22);
            this.btnListContainers.Name = "btnListContainers";
            this.btnListContainers.Size = new System.Drawing.Size(100, 23);
            this.btnListContainers.TabIndex = 0;
            this.btnListContainers.Text = "Listar todos";
            this.btnListContainers.UseVisualStyleBackColor = true;
            this.btnListContainers.Click += new System.EventHandler(this.btnListContainers_Click);
            // 
            // gbImages
            // 
            this.gbImages.Controls.Add(this.btnDeleteImagesAll);
            this.gbImages.Controls.Add(this.btnDeleteImage);
            this.gbImages.Controls.Add(this.label4);
            this.gbImages.Controls.Add(this.textBox2);
            this.gbImages.Controls.Add(this.btnCreateImage);
            this.gbImages.Controls.Add(this.label5);
            this.gbImages.Controls.Add(this.txtImage);
            this.gbImages.Controls.Add(this.lblImages);
            this.gbImages.Controls.Add(this.btnListImages);
            this.gbImages.Location = new System.Drawing.Point(428, 10);
            this.gbImages.Name = "gbImages";
            this.gbImages.Size = new System.Drawing.Size(392, 458);
            this.gbImages.TabIndex = 1;
            this.gbImages.TabStop = false;
            this.gbImages.Text = "Images";
            // 
            // btnDeleteImagesAll
            // 
            this.btnDeleteImagesAll.Location = new System.Drawing.Point(228, 22);
            this.btnDeleteImagesAll.Name = "btnDeleteImagesAll";
            this.btnDeleteImagesAll.Size = new System.Drawing.Size(158, 23);
            this.btnDeleteImagesAll.TabIndex = 17;
            this.btnDeleteImagesAll.Text = "Deletar Todas Images";
            this.btnDeleteImagesAll.UseVisualStyleBackColor = true;
            this.btnDeleteImagesAll.Click += new System.EventHandler(this.btnDeleteImagesAll_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Location = new System.Drawing.Point(154, 429);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(133, 23);
            this.btnDeleteImage.TabIndex = 16;
            this.btnDeleteImage.Text = "Deletar Image";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 429);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 23);
            this.textBox2.TabIndex = 14;
            // 
            // btnCreateImage
            // 
            this.btnCreateImage.Location = new System.Drawing.Point(6, 372);
            this.btnCreateImage.Name = "btnCreateImage";
            this.btnCreateImage.Size = new System.Drawing.Size(133, 23);
            this.btnCreateImage.TabIndex = 13;
            this.btnCreateImage.Text = "Criar Image";
            this.btnCreateImage.UseVisualStyleBackColor = true;
            this.btnCreateImage.Click += new System.EventHandler(this.btnCreateImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(6, 329);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(169, 23);
            this.txtImage.TabIndex = 11;
            this.txtImage.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblImages
            // 
            this.lblImages.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImages.Location = new System.Drawing.Point(6, 60);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(380, 234);
            this.lblImages.TabIndex = 2;
            this.lblImages.Text = "label1";
            // 
            // btnListImages
            // 
            this.btnListImages.Location = new System.Drawing.Point(6, 22);
            this.btnListImages.Name = "btnListImages";
            this.btnListImages.Size = new System.Drawing.Size(100, 23);
            this.btnListImages.TabIndex = 1;
            this.btnListImages.Text = "Listar todos";
            this.btnListImages.UseVisualStyleBackColor = true;
            this.btnListImages.Click += new System.EventHandler(this.btnListImages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 480);
            this.Controls.Add(this.gbImages);
            this.Controls.Add(this.gbContainers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbContainers.ResumeLayout(false);
            this.gbContainers.PerformLayout();
            this.gbImages.ResumeLayout(false);
            this.gbImages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContainers;
        private System.Windows.Forms.Label lblContainers;
        private System.Windows.Forms.Button btnListContainers;
        private System.Windows.Forms.GroupBox gbImages;
        private System.Windows.Forms.Label lblImages;
        private System.Windows.Forms.Button btnListImages;
        private System.Windows.Forms.Button btnDeleteImageAll;
        private System.Windows.Forms.Button btnDeleteContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCreateContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnDeleteImagesAll;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCreateImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImage;
    }
}
