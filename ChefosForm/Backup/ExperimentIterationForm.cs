using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace ChefosForm
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class formReadExperiment : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public formReadExperiment()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public formReadExperiment(string offersFile)
        {
            System.IO.StreamReader streamReader = System.IO.File.OpenText(offersFile);
            string experimentIterationAsString = streamReader.ReadLine();
            while (experimentIterationAsString != null)
            {
                experimentIterations.Add(new ExperimentIteration(experimentIterationAsString));
                experimentIterationAsString = streamReader.ReadLine();
            }
            streamReader.Close();

            InitializeComponent();

            currentIteration = 0;
            omniumQuantity = 0;
            nextBtn.Enabled = true;

            performIteration();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReadExperiment));
            this.offersPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.fourthSupplierRealPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.fourthSuppliarRealLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.fourthSupplierOfferLabel = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.secondSuppliarRealPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.secondSuppliarRealLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.thirdSupplierRealPanel = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.thirdSupplierRealLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.secondSupplierOfferLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.thirdSupplierOfferLabel = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstSupplierRealPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.firstSuppliarRealLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstSupplierOfferLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstSuppierBtn = new System.Windows.Forms.Button();
            this.secondSupplierBtn = new System.Windows.Forms.Button();
            this.thirdSupplierBtn = new System.Windows.Forms.Button();
            this.fourthSupplierBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.omniumQuontityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.offersPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.fourthSupplierRealPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.secondSuppliarRealPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.thirdSupplierRealPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.firstSupplierRealPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // offersPanel
            // 
            this.offersPanel.Controls.Add(this.panel5);
            this.offersPanel.Controls.Add(this.panel6);
            this.offersPanel.Controls.Add(this.panel3);
            this.offersPanel.Controls.Add(this.panel7);
            this.offersPanel.Controls.Add(this.panel4);
            this.offersPanel.Controls.Add(this.panel8);
            this.offersPanel.Controls.Add(this.panel2);
            this.offersPanel.Controls.Add(this.panel1);
            this.offersPanel.Location = new System.Drawing.Point(14, 12);
            this.offersPanel.Name = "offersPanel";
            this.offersPanel.Size = new System.Drawing.Size(657, 390);
            this.offersPanel.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.fourthSupplierRealPanel);
            this.panel5.Location = new System.Drawing.Point(338, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 88);
            this.panel5.TabIndex = 11;
            // 
            // fourthSupplierRealPanel
            // 
            this.fourthSupplierRealPanel.Controls.Add(this.label20);
            this.fourthSupplierRealPanel.Controls.Add(this.label26);
            this.fourthSupplierRealPanel.Controls.Add(this.fourthSuppliarRealLabel);
            this.fourthSupplierRealPanel.Location = new System.Drawing.Point(26, 11);
            this.fourthSupplierRealPanel.Name = "fourthSupplierRealPanel";
            this.fourthSupplierRealPanel.Size = new System.Drawing.Size(212, 70);
            this.fourthSupplierRealPanel.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(35, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 17);
            this.label20.TabIndex = 5;
            this.label20.Text = "опаковки омниум";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(3, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(197, 17);
            this.label26.TabIndex = 1;
            this.label26.Text = "Реално ще бъдат доставени";
            // 
            // fourthSuppliarRealLabel
            // 
            this.fourthSuppliarRealLabel.AutoSize = true;
            this.fourthSuppliarRealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthSuppliarRealLabel.Location = new System.Drawing.Point(3, 46);
            this.fourthSuppliarRealLabel.Name = "fourthSuppliarRealLabel";
            this.fourthSuppliarRealLabel.Size = new System.Drawing.Size(26, 17);
            this.fourthSuppliarRealLabel.TabIndex = 5;
            this.fourthSuppliarRealLabel.Text = "50";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.fourthSupplierOfferLabel);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Controls.Add(this.label30);
            this.panel6.Controls.Add(this.label31);
            this.panel6.Location = new System.Drawing.Point(338, 203);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 88);
            this.panel6.TabIndex = 10;
            // 
            // fourthSupplierOfferLabel
            // 
            this.fourthSupplierOfferLabel.AutoSize = true;
            this.fourthSupplierOfferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthSupplierOfferLabel.Location = new System.Drawing.Point(102, 49);
            this.fourthSupplierOfferLabel.Name = "fourthSupplierOfferLabel";
            this.fourthSupplierOfferLabel.Size = new System.Drawing.Size(26, 17);
            this.fourthSupplierOfferLabel.TabIndex = 4;
            this.fourthSupplierOfferLabel.Text = "60";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(134, 49);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(122, 17);
            this.label28.TabIndex = 3;
            this.label28.Text = "опаковки омниум";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(31, 49);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 17);
            this.label29.TabIndex = 2;
            this.label29.Text = "Оферта:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(163, 19);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(16, 13);
            this.label30.TabIndex = 1;
            this.label30.Text = "D";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(74, 15);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 17);
            this.label31.TabIndex = 0;
            this.label31.Text = "Доставчик:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.secondSuppliarRealPanel);
            this.panel3.Location = new System.Drawing.Point(338, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 88);
            this.panel3.TabIndex = 7;
            // 
            // secondSuppliarRealPanel
            // 
            this.secondSuppliarRealPanel.Controls.Add(this.label17);
            this.secondSuppliarRealPanel.Controls.Add(this.label19);
            this.secondSuppliarRealPanel.Controls.Add(this.secondSuppliarRealLabel);
            this.secondSuppliarRealPanel.Location = new System.Drawing.Point(26, 3);
            this.secondSuppliarRealPanel.Name = "secondSuppliarRealPanel";
            this.secondSuppliarRealPanel.Size = new System.Drawing.Size(220, 77);
            this.secondSuppliarRealPanel.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(48, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "опаковки омниум";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(3, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Реално ще бъдат доставени";
            // 
            // secondSuppliarRealLabel
            // 
            this.secondSuppliarRealLabel.AutoSize = true;
            this.secondSuppliarRealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondSuppliarRealLabel.Location = new System.Drawing.Point(16, 42);
            this.secondSuppliarRealLabel.Name = "secondSuppliarRealLabel";
            this.secondSuppliarRealLabel.Size = new System.Drawing.Size(26, 17);
            this.secondSuppliarRealLabel.TabIndex = 5;
            this.secondSuppliarRealLabel.Text = "50";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.thirdSupplierRealPanel);
            this.panel7.Location = new System.Drawing.Point(16, 288);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 88);
            this.panel7.TabIndex = 9;
            // 
            // thirdSupplierRealPanel
            // 
            this.thirdSupplierRealPanel.Controls.Add(this.label32);
            this.thirdSupplierRealPanel.Controls.Add(this.label34);
            this.thirdSupplierRealPanel.Controls.Add(this.thirdSupplierRealLabel);
            this.thirdSupplierRealPanel.Location = new System.Drawing.Point(21, 8);
            this.thirdSupplierRealPanel.Name = "thirdSupplierRealPanel";
            this.thirdSupplierRealPanel.Size = new System.Drawing.Size(234, 73);
            this.thirdSupplierRealPanel.TabIndex = 13;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(42, 49);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(122, 17);
            this.label32.TabIndex = 5;
            this.label32.Text = "опаковки омниум";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(10, 15);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(197, 17);
            this.label34.TabIndex = 1;
            this.label34.Text = "Реално ще бъдат доставени";
            // 
            // thirdSupplierRealLabel
            // 
            this.thirdSupplierRealLabel.AutoSize = true;
            this.thirdSupplierRealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdSupplierRealLabel.Location = new System.Drawing.Point(10, 49);
            this.thirdSupplierRealLabel.Name = "thirdSupplierRealLabel";
            this.thirdSupplierRealLabel.Size = new System.Drawing.Size(26, 17);
            this.thirdSupplierRealLabel.TabIndex = 5;
            this.thirdSupplierRealLabel.Text = "50";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.secondSupplierOfferLabel);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(338, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 88);
            this.panel4.TabIndex = 6;
            // 
            // secondSupplierOfferLabel
            // 
            this.secondSupplierOfferLabel.AutoSize = true;
            this.secondSupplierOfferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondSupplierOfferLabel.Location = new System.Drawing.Point(102, 49);
            this.secondSupplierOfferLabel.Name = "secondSupplierOfferLabel";
            this.secondSupplierOfferLabel.Size = new System.Drawing.Size(26, 17);
            this.secondSupplierOfferLabel.TabIndex = 4;
            this.secondSupplierOfferLabel.Text = "60";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(134, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "опаковки омниум";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(31, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 17);
            this.label22.TabIndex = 2;
            this.label22.Text = "Оферта:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(163, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "B";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(74, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 17);
            this.label24.TabIndex = 0;
            this.label24.Text = "Доставчик:";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.thirdSupplierOfferLabel);
            this.panel8.Controls.Add(this.label36);
            this.panel8.Controls.Add(this.label37);
            this.panel8.Controls.Add(this.label38);
            this.panel8.Controls.Add(this.label39);
            this.panel8.Location = new System.Drawing.Point(16, 203);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(298, 88);
            this.panel8.TabIndex = 8;
            // 
            // thirdSupplierOfferLabel
            // 
            this.thirdSupplierOfferLabel.AutoSize = true;
            this.thirdSupplierOfferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdSupplierOfferLabel.Location = new System.Drawing.Point(102, 49);
            this.thirdSupplierOfferLabel.Name = "thirdSupplierOfferLabel";
            this.thirdSupplierOfferLabel.Size = new System.Drawing.Size(26, 17);
            this.thirdSupplierOfferLabel.TabIndex = 4;
            this.thirdSupplierOfferLabel.Text = "60";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(134, 49);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(122, 17);
            this.label36.TabIndex = 3;
            this.label36.Text = "опаковки омниум";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.Location = new System.Drawing.Point(31, 49);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 17);
            this.label37.TabIndex = 2;
            this.label37.Text = "Оферта:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.Location = new System.Drawing.Point(163, 19);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(15, 13);
            this.label38.TabIndex = 1;
            this.label38.Text = "C";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(74, 15);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(83, 17);
            this.label39.TabIndex = 0;
            this.label39.Text = "Доставчик:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.firstSupplierRealPanel);
            this.panel2.Location = new System.Drawing.Point(16, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 88);
            this.panel2.TabIndex = 1;
            // 
            // firstSupplierRealPanel
            // 
            this.firstSupplierRealPanel.Controls.Add(this.label16);
            this.firstSupplierRealPanel.Controls.Add(this.firstSuppliarRealLabel);
            this.firstSupplierRealPanel.Controls.Add(this.label14);
            this.firstSupplierRealPanel.Location = new System.Drawing.Point(21, 3);
            this.firstSupplierRealPanel.Name = "firstSupplierRealPanel";
            this.firstSupplierRealPanel.Size = new System.Drawing.Size(220, 72);
            this.firstSupplierRealPanel.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(42, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "опаковки омниум";
            // 
            // firstSuppliarRealLabel
            // 
            this.firstSuppliarRealLabel.AutoSize = true;
            this.firstSuppliarRealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSuppliarRealLabel.Location = new System.Drawing.Point(10, 42);
            this.firstSuppliarRealLabel.Name = "firstSuppliarRealLabel";
            this.firstSuppliarRealLabel.Size = new System.Drawing.Size(26, 17);
            this.firstSuppliarRealLabel.TabIndex = 5;
            this.firstSuppliarRealLabel.Text = "50";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(10, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Реално ще бъдат доставени";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.firstSupplierOfferLabel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 88);
            this.panel1.TabIndex = 0;
            // 
            // firstSupplierOfferLabel
            // 
            this.firstSupplierOfferLabel.AutoSize = true;
            this.firstSupplierOfferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSupplierOfferLabel.Location = new System.Drawing.Point(102, 49);
            this.firstSupplierOfferLabel.Name = "firstSupplierOfferLabel";
            this.firstSupplierOfferLabel.Size = new System.Drawing.Size(26, 17);
            this.firstSupplierOfferLabel.TabIndex = 4;
            this.firstSupplierOfferLabel.Text = "60";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(134, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "опаковки омниум";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(31, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Оферта:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(163, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "А";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доставчик:";
            // 
            // firstSuppierBtn
            // 
            this.firstSuppierBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.firstSuppierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstSuppierBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSuppierBtn.Location = new System.Drawing.Point(14, 418);
            this.firstSuppierBtn.Name = "firstSuppierBtn";
            this.firstSuppierBtn.Size = new System.Drawing.Size(145, 70);
            this.firstSuppierBtn.TabIndex = 13;
            this.firstSuppierBtn.Text = "Избирам\r\n А";
            this.firstSuppierBtn.UseVisualStyleBackColor = false;
            this.firstSuppierBtn.Click += new System.EventHandler(this.firstSuppierBtn_Click);
            // 
            // secondSupplierBtn
            // 
            this.secondSupplierBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.secondSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondSupplierBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondSupplierBtn.Location = new System.Drawing.Point(185, 418);
            this.secondSupplierBtn.Name = "secondSupplierBtn";
            this.secondSupplierBtn.Size = new System.Drawing.Size(143, 70);
            this.secondSupplierBtn.TabIndex = 14;
            this.secondSupplierBtn.Text = "Избирам\r\n B";
            this.secondSupplierBtn.UseVisualStyleBackColor = false;
            this.secondSupplierBtn.Click += new System.EventHandler(this.secondSupplierBtn_Click);
            // 
            // thirdSupplierBtn
            // 
            this.thirdSupplierBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.thirdSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdSupplierBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdSupplierBtn.Location = new System.Drawing.Point(352, 418);
            this.thirdSupplierBtn.Name = "thirdSupplierBtn";
            this.thirdSupplierBtn.Size = new System.Drawing.Size(142, 70);
            this.thirdSupplierBtn.TabIndex = 15;
            this.thirdSupplierBtn.Text = "Избирам\r\n С";
            this.thirdSupplierBtn.UseVisualStyleBackColor = false;
            this.thirdSupplierBtn.Click += new System.EventHandler(this.thirdSupplierBtn_Click);
            // 
            // fourthSupplierBtn
            // 
            this.fourthSupplierBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.fourthSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourthSupplierBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthSupplierBtn.Location = new System.Drawing.Point(529, 418);
            this.fourthSupplierBtn.Name = "fourthSupplierBtn";
            this.fourthSupplierBtn.Size = new System.Drawing.Size(142, 70);
            this.fourthSupplierBtn.TabIndex = 16;
            this.fourthSupplierBtn.Text = "Избирам\r\n D";
            this.fourthSupplierBtn.UseVisualStyleBackColor = false;
            this.fourthSupplierBtn.Click += new System.EventHandler(this.fourthSupplierBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Общо количество омниум";
            // 
            // omniumQuontityLabel
            // 
            this.omniumQuontityLabel.AutoSize = true;
            this.omniumQuontityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omniumQuontityLabel.Location = new System.Drawing.Point(105, 536);
            this.omniumQuontityLabel.Name = "omniumQuontityLabel";
            this.omniumQuontityLabel.Size = new System.Drawing.Size(35, 17);
            this.omniumQuontityLabel.TabIndex = 18;
            this.omniumQuontityLabel.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "до момента:";
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.nextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.BackgroundImage")));
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextBtn.Location = new System.Drawing.Point(529, 523);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(142, 36);
            this.nextBtn.TabIndex = 20;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // formReadExperiment
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 567);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.omniumQuontityLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fourthSupplierBtn);
            this.Controls.Add(this.thirdSupplierBtn);
            this.Controls.Add(this.secondSupplierBtn);
            this.Controls.Add(this.firstSuppierBtn);
            this.Controls.Add(this.offersPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 576);
            this.Name = "formReadExperiment";
            this.Text = "READ Експеримент";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.formReadExperiment_Closing);
            this.offersPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.fourthSupplierRealPanel.ResumeLayout(false);
            this.fourthSupplierRealPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.secondSuppliarRealPanel.ResumeLayout(false);
            this.secondSuppliarRealPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.thirdSupplierRealPanel.ResumeLayout(false);
            this.thirdSupplierRealPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.firstSupplierRealPanel.ResumeLayout(false);
            this.firstSupplierRealPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private ArrayList experimentIterations = new ArrayList();
        private int currentIteration;
        /*
        private ArrayList panelsToShow = new ArrayList();
        private ArrayList timeToShowPanels =  new ArrayList();
        private Timer timer;
        private string currentSupplier = "A";
         */
        private Panel offersPanel;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label label17;
        private Label secondSuppliarRealLabel;
        private Label label19;
        private Panel panel4;
        private Label secondSupplierOfferLabel;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label16;
        private Label firstSuppliarRealLabel;
        private Label label14;
        private Panel panel5;
        private Label label20;
        private Label fourthSuppliarRealLabel;
        private Label label26;
        private Panel panel6;
        private Label fourthSupplierOfferLabel;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Panel panel7;
        private Label label32;
        private Label thirdSupplierRealLabel;
        private Label label34;
        private Panel panel8;
        private Label thirdSupplierOfferLabel;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label firstSupplierOfferLabel;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label1;
        private Panel firstSupplierRealPanel;
        private Panel secondSuppliarRealPanel;
        private Panel thirdSupplierRealPanel;
        private Panel fourthSupplierRealPanel;
        private Button firstSuppierBtn;
        private Button secondSupplierBtn;
        private Button thirdSupplierBtn;
        private Button fourthSupplierBtn;
        private Label label2;
        private Label omniumQuontityLabel;
        private Label label3;
        private Button nextBtn;
        private bool allowClose = false;
        private int omniumQuantity;
        private string[] supplierNames = { "A", "B", "C", "D" };
        private int supplierIndx;
        private Stopwatch nextSwtopwatch = new Stopwatch();
        private Stopwatch choiceStopwatch = new Stopwatch();
        private int choiceTime;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new InstructionsForm());
        }

        public void nextIteration()
        {
            currentIteration++;
            if (currentIteration >= experimentIterations.Count)
            {
                MessageBox.Show("Благодарим, че взехте участие в експеримента",
                    "READ Експеримент",
                    MessageBoxButtons.OK);

                allowClose = true;
                Close();
            }
            enableButtons();
            performIteration();
        }

        private void performIteration()
        {
            enableButtons();
            this.Visible = true;

            ExperimentIteration it = (ExperimentIteration)experimentIterations[currentIteration];

            omniumQuontityLabel.Text = omniumQuantity.ToString();

            firstSupplierRealPanel.Visible = false;

            secondSuppliarRealPanel.Visible = false;
            thirdSupplierRealPanel.Visible = false;
            fourthSupplierRealPanel.Visible = false;

            firstSupplierOfferLabel.Text = it.Suppliers[0].AdPrice;
            secondSupplierOfferLabel.Text = it.Suppliers[1].AdPrice;
            thirdSupplierOfferLabel.Text = it.Suppliers[2].AdPrice;
            fourthSupplierOfferLabel.Text = it.Suppliers[3].AdPrice;

            firstSuppliarRealLabel.Text = it.Suppliers[0].RealPrice;
            secondSuppliarRealLabel.Text = it.Suppliers[1].RealPrice;
            thirdSupplierRealLabel.Text = it.Suppliers[2].RealPrice;
            fourthSuppliarRealLabel.Text = it.Suppliers[3].RealPrice;

            choiceStopwatch.start();
        }

        private void formReadExperiment_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!allowClose)
            {
                e.Cancel = true; //don't close 		
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void desableButtons()
        {
            firstSuppierBtn.Enabled = false;
            secondSupplierBtn.Enabled = false;
            thirdSupplierBtn.Enabled = false;
            fourthSupplierBtn.Enabled = false;

            nextBtn.Enabled = true;
        }

        private void enableButtons()
        {
            firstSuppierBtn.Enabled = true;
            secondSupplierBtn.Enabled = true;
            thirdSupplierBtn.Enabled = true;
            fourthSupplierBtn.Enabled = true;

            nextBtn.Enabled = false;
        }

        private void firstSuppierBtn_Click(object sender, EventArgs e)
        {
            supplierIndx = 0;

            ExperimentIteration it = (ExperimentIteration)experimentIterations[currentIteration];

            omniumQuantity += int.Parse(it.Suppliers[supplierIndx].RealPrice);
            omniumQuontityLabel.Text = omniumQuantity.ToString();
            firstSupplierRealPanel.Visible = true;
            desableButtons();
            nextSwtopwatch.start();
            choiceTime = choiceStopwatch.stop();
        }

        private void secondSupplierBtn_Click(object sender, EventArgs e)
        {
            supplierIndx = 1;

            ExperimentIteration it = (ExperimentIteration)experimentIterations[currentIteration];

            omniumQuantity += int.Parse(it.Suppliers[supplierIndx].RealPrice);
            omniumQuontityLabel.Text = omniumQuantity.ToString();
            secondSuppliarRealPanel.Visible = true;
            desableButtons();
            nextSwtopwatch.start();
            choiceTime = choiceStopwatch.stop();
        }

        private void thirdSupplierBtn_Click(object sender, EventArgs e)
        {
            supplierIndx = 2;

            ExperimentIteration it = (ExperimentIteration)experimentIterations[currentIteration];

            omniumQuantity += int.Parse(it.Suppliers[supplierIndx].RealPrice);
            omniumQuontityLabel.Text = omniumQuantity.ToString();
            thirdSupplierRealPanel.Visible = true;
            desableButtons();
            nextSwtopwatch.start();
            choiceTime = choiceStopwatch.stop();

        }

        private void fourthSupplierBtn_Click(object sender, EventArgs e)
        {
            supplierIndx = 3;

            ExperimentIteration it = (ExperimentIteration)experimentIterations[currentIteration];

            omniumQuantity += int.Parse(it.Suppliers[supplierIndx].RealPrice);
            omniumQuontityLabel.Text = omniumQuantity.ToString();
            fourthSupplierRealPanel.Visible = true;
            desableButtons();
            nextSwtopwatch.start();
            choiceTime = choiceStopwatch.stop();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            ExperimentIteration it = (ExperimentIteration)experimentIterations[currentIteration];
            DSScaleChoice frm =
                new DSScaleChoice(supplierNames[supplierIndx], 
                                  it.Suppliers[supplierIndx].AdPrice, 
                                  it.Suppliers[supplierIndx].RealPrice, 
                                  omniumQuantity.ToString(),
                                  choiceTime,
                                  nextSwtopwatch.stop(),
                                  this);
            this.Visible = false;
            frm.ShowDialog();
        }

    }
}