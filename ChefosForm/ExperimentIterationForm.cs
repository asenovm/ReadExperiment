using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Transitions;

namespace Read
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class FormReadExperiment : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FormReadExperiment()
        {
            InitializeComponent();
        }

        private const string OFFERS_FILE = "SuppliersOffers.txt";

        public FormReadExperiment(string outputFile)
        {
            ReadExperimentData(OFFERS_FILE);

            InitializeComponent();

            colors = new ColorsList();
            animator = new Animator();

            feedbackWatch = new Stopwatch();
            currentIteration = 0;
            omniumQuantity = 0;
            nextBtn.Enabled = true;
            this.outputFile = outputFile;

            PerformIteration();
        }

        private void ReadExperimentData(string offersFile)
        {
            System.IO.StreamReader streamReader = System.IO.File.OpenText(offersFile);
            string experimentIterationAsString = streamReader.ReadLine();
            while (experimentIterationAsString != null)
            {
                experimentIterations.Add(new ExperimentIteration(experimentIterationAsString));
                experimentIterationAsString = streamReader.ReadLine();
            }
            streamReader.Close();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReadExperiment));
            this.firstSuppierBtn = new System.Windows.Forms.Button();
            this.secondSupplierBtn = new System.Windows.Forms.Button();
            this.thirdSupplierBtn = new System.Windows.Forms.Button();
            this.fourthSupplierBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.omniumQuontityLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstSupplierOfferLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstSupplierRealPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.firstSuppliarRealLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.thirdSupplierOfferLabel = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.secondSupplierOfferLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.thirdSupplierRealPanel = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.thirdSupplierRealLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.secondSuppliarRealPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.secondSuppliarRealLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.fourthSupplierOfferLabel = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.fourthSupplierRealPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.fourthSuppliarRealLabel = new System.Windows.Forms.Label();
            this.offersPanel = new System.Windows.Forms.Panel();
            this.manufacturingIncreasePanel = new System.Windows.Forms.Panel();
            this.manufacturingIncreaseValueLabel = new System.Windows.Forms.Label();
            this.manufacturingIncreaseTextLabel = new System.Windows.Forms.Label();
            this.manufacturingLevelsPanel = new System.Windows.Forms.Panel();
            this.manufacturingLevelUnitsLabel = new System.Windows.Forms.Label();
            this.manufacturingLevelsValueLabel = new System.Windows.Forms.Label();
            this.manufacturingLevelsTextLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.firstSupplierRealPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.thirdSupplierRealPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.secondSuppliarRealPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.fourthSupplierRealPanel.SuspendLayout();
            this.offersPanel.SuspendLayout();
            this.manufacturingIncreasePanel.SuspendLayout();
            this.manufacturingLevelsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstSuppierBtn
            // 
            this.firstSuppierBtn.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.firstSuppierBtn, "firstSuppierBtn");
            this.firstSuppierBtn.Name = "firstSuppierBtn";
            this.firstSuppierBtn.TabStop = false;
            this.firstSuppierBtn.UseVisualStyleBackColor = false;
            this.firstSuppierBtn.Click += new System.EventHandler(this.FirstSuppierBtn_Click);
            // 
            // secondSupplierBtn
            // 
            this.secondSupplierBtn.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.secondSupplierBtn, "secondSupplierBtn");
            this.secondSupplierBtn.Name = "secondSupplierBtn";
            this.secondSupplierBtn.TabStop = false;
            this.secondSupplierBtn.UseVisualStyleBackColor = false;
            this.secondSupplierBtn.Click += new System.EventHandler(this.SecondSupplierBtn_Click);
            // 
            // thirdSupplierBtn
            // 
            this.thirdSupplierBtn.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.thirdSupplierBtn, "thirdSupplierBtn");
            this.thirdSupplierBtn.Name = "thirdSupplierBtn";
            this.thirdSupplierBtn.TabStop = false;
            this.thirdSupplierBtn.UseVisualStyleBackColor = false;
            this.thirdSupplierBtn.Click += new System.EventHandler(this.ThirdSupplierBtn_Click);
            // 
            // fourthSupplierBtn
            // 
            this.fourthSupplierBtn.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.fourthSupplierBtn, "fourthSupplierBtn");
            this.fourthSupplierBtn.Name = "fourthSupplierBtn";
            this.fourthSupplierBtn.TabStop = false;
            this.fourthSupplierBtn.UseVisualStyleBackColor = false;
            this.fourthSupplierBtn.Click += new System.EventHandler(this.FourthSupplierBtn_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // omniumQuontityLabel
            // 
            resources.ApplyResources(this.omniumQuontityLabel, "omniumQuontityLabel");
            this.omniumQuontityLabel.Name = "omniumQuontityLabel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            resources.ApplyResources(this.nextBtn, "nextBtn");
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.firstSupplierOfferLabel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // firstSupplierOfferLabel
            // 
            resources.ApplyResources(this.firstSupplierOfferLabel, "firstSupplierOfferLabel");
            this.firstSupplierOfferLabel.Name = "firstSupplierOfferLabel";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.firstSupplierRealPanel);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // firstSupplierRealPanel
            // 
            this.firstSupplierRealPanel.Controls.Add(this.label16);
            this.firstSupplierRealPanel.Controls.Add(this.firstSuppliarRealLabel);
            this.firstSupplierRealPanel.Controls.Add(this.label14);
            resources.ApplyResources(this.firstSupplierRealPanel, "firstSupplierRealPanel");
            this.firstSupplierRealPanel.Name = "firstSupplierRealPanel";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // firstSuppliarRealLabel
            // 
            resources.ApplyResources(this.firstSuppliarRealLabel, "firstSuppliarRealLabel");
            this.firstSuppliarRealLabel.Name = "firstSuppliarRealLabel";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.thirdSupplierOfferLabel);
            this.panel8.Controls.Add(this.label36);
            this.panel8.Controls.Add(this.label37);
            this.panel8.Controls.Add(this.label38);
            this.panel8.Controls.Add(this.label39);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // thirdSupplierOfferLabel
            // 
            resources.ApplyResources(this.thirdSupplierOfferLabel, "thirdSupplierOfferLabel");
            this.thirdSupplierOfferLabel.Name = "thirdSupplierOfferLabel";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.secondSupplierOfferLabel);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label24);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // secondSupplierOfferLabel
            // 
            resources.ApplyResources(this.secondSupplierOfferLabel, "secondSupplierOfferLabel");
            this.secondSupplierOfferLabel.Name = "secondSupplierOfferLabel";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.thirdSupplierRealPanel);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // thirdSupplierRealPanel
            // 
            this.thirdSupplierRealPanel.Controls.Add(this.label32);
            this.thirdSupplierRealPanel.Controls.Add(this.label34);
            this.thirdSupplierRealPanel.Controls.Add(this.thirdSupplierRealLabel);
            resources.ApplyResources(this.thirdSupplierRealPanel, "thirdSupplierRealPanel");
            this.thirdSupplierRealPanel.Name = "thirdSupplierRealPanel";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // thirdSupplierRealLabel
            // 
            resources.ApplyResources(this.thirdSupplierRealLabel, "thirdSupplierRealLabel");
            this.thirdSupplierRealLabel.Name = "thirdSupplierRealLabel";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.secondSuppliarRealPanel);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // secondSuppliarRealPanel
            // 
            this.secondSuppliarRealPanel.Controls.Add(this.label17);
            this.secondSuppliarRealPanel.Controls.Add(this.label19);
            this.secondSuppliarRealPanel.Controls.Add(this.secondSuppliarRealLabel);
            resources.ApplyResources(this.secondSuppliarRealPanel, "secondSuppliarRealPanel");
            this.secondSuppliarRealPanel.Name = "secondSuppliarRealPanel";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // secondSuppliarRealLabel
            // 
            resources.ApplyResources(this.secondSuppliarRealLabel, "secondSuppliarRealLabel");
            this.secondSuppliarRealLabel.Name = "secondSuppliarRealLabel";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.fourthSupplierOfferLabel);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Controls.Add(this.label30);
            this.panel6.Controls.Add(this.label31);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // fourthSupplierOfferLabel
            // 
            resources.ApplyResources(this.fourthSupplierOfferLabel, "fourthSupplierOfferLabel");
            this.fourthSupplierOfferLabel.Name = "fourthSupplierOfferLabel";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.fourthSupplierRealPanel);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // fourthSupplierRealPanel
            // 
            this.fourthSupplierRealPanel.Controls.Add(this.label20);
            this.fourthSupplierRealPanel.Controls.Add(this.label26);
            this.fourthSupplierRealPanel.Controls.Add(this.fourthSuppliarRealLabel);
            resources.ApplyResources(this.fourthSupplierRealPanel, "fourthSupplierRealPanel");
            this.fourthSupplierRealPanel.Name = "fourthSupplierRealPanel";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // fourthSuppliarRealLabel
            // 
            resources.ApplyResources(this.fourthSuppliarRealLabel, "fourthSuppliarRealLabel");
            this.fourthSuppliarRealLabel.Name = "fourthSuppliarRealLabel";
            // 
            // offersPanel
            // 
            this.offersPanel.Controls.Add(this.manufacturingIncreasePanel);
            this.offersPanel.Controls.Add(this.manufacturingLevelsPanel);
            this.offersPanel.Controls.Add(this.panel5);
            this.offersPanel.Controls.Add(this.panel6);
            this.offersPanel.Controls.Add(this.panel3);
            this.offersPanel.Controls.Add(this.panel7);
            this.offersPanel.Controls.Add(this.panel4);
            this.offersPanel.Controls.Add(this.panel8);
            this.offersPanel.Controls.Add(this.panel2);
            this.offersPanel.Controls.Add(this.panel1);
            resources.ApplyResources(this.offersPanel, "offersPanel");
            this.offersPanel.Name = "offersPanel";
            // 
            // manufacturingIncreasePanel
            // 
            this.manufacturingIncreasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manufacturingIncreasePanel.Controls.Add(this.manufacturingIncreaseValueLabel);
            this.manufacturingIncreasePanel.Controls.Add(this.manufacturingIncreaseTextLabel);
            resources.ApplyResources(this.manufacturingIncreasePanel, "manufacturingIncreasePanel");
            this.manufacturingIncreasePanel.Name = "manufacturingIncreasePanel";
            // 
            // manufacturingIncreaseValueLabel
            // 
            resources.ApplyResources(this.manufacturingIncreaseValueLabel, "manufacturingIncreaseValueLabel");
            this.manufacturingIncreaseValueLabel.Name = "manufacturingIncreaseValueLabel";
            // 
            // manufacturingIncreaseTextLabel
            // 
            resources.ApplyResources(this.manufacturingIncreaseTextLabel, "manufacturingIncreaseTextLabel");
            this.manufacturingIncreaseTextLabel.Name = "manufacturingIncreaseTextLabel";
            // 
            // manufacturingLevelsPanel
            // 
            this.manufacturingLevelsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manufacturingLevelsPanel.Controls.Add(this.manufacturingLevelUnitsLabel);
            this.manufacturingLevelsPanel.Controls.Add(this.manufacturingLevelsValueLabel);
            this.manufacturingLevelsPanel.Controls.Add(this.manufacturingLevelsTextLabel);
            resources.ApplyResources(this.manufacturingLevelsPanel, "manufacturingLevelsPanel");
            this.manufacturingLevelsPanel.Name = "manufacturingLevelsPanel";
            // 
            // manufacturingLevelUnitsLabel
            // 
            resources.ApplyResources(this.manufacturingLevelUnitsLabel, "manufacturingLevelUnitsLabel");
            this.manufacturingLevelUnitsLabel.Name = "manufacturingLevelUnitsLabel";
            // 
            // manufacturingLevelsValueLabel
            // 
            resources.ApplyResources(this.manufacturingLevelsValueLabel, "manufacturingLevelsValueLabel");
            this.manufacturingLevelsValueLabel.Name = "manufacturingLevelsValueLabel";
            // 
            // manufacturingLevelsTextLabel
            // 
            resources.ApplyResources(this.manufacturingLevelsTextLabel, "manufacturingLevelsTextLabel");
            this.manufacturingLevelsTextLabel.Name = "manufacturingLevelsTextLabel";
            // 
            // FormReadExperiment
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
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
            this.MinimizeBox = false;
            this.Name = "FormReadExperiment";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormReadExperiment_Closing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.firstSupplierRealPanel.ResumeLayout(false);
            this.firstSupplierRealPanel.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.thirdSupplierRealPanel.ResumeLayout(false);
            this.thirdSupplierRealPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.secondSuppliarRealPanel.ResumeLayout(false);
            this.secondSuppliarRealPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.fourthSupplierRealPanel.ResumeLayout(false);
            this.fourthSupplierRealPanel.PerformLayout();
            this.offersPanel.ResumeLayout(false);
            this.manufacturingIncreasePanel.ResumeLayout(false);
            this.manufacturingIncreasePanel.PerformLayout();
            this.manufacturingLevelsPanel.ResumeLayout(false);
            this.manufacturingLevelsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private List<ExperimentIteration> experimentIterations = new List<ExperimentIteration>();
        private int currentIteration;
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
        private Panel panel1;
        private Label firstSupplierOfferLabel;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label1;
        private Panel panel2;
        private Panel firstSupplierRealPanel;
        private Label label16;
        private Label firstSuppliarRealLabel;
        private Label label14;
        private Panel panel8;
        private Label thirdSupplierOfferLabel;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Panel panel4;
        private Label secondSupplierOfferLabel;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Panel panel7;
        private Panel thirdSupplierRealPanel;
        private Label label32;
        private Label label34;
        private Label thirdSupplierRealLabel;
        private Panel panel3;
        private Panel secondSuppliarRealPanel;
        private Label label17;
        private Label label19;
        private Label secondSuppliarRealLabel;
        private Panel panel6;
        private Label fourthSupplierOfferLabel;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Panel panel5;
        private Panel fourthSupplierRealPanel;
        private Label label20;
        private Label label26;
        private Label fourthSuppliarRealLabel;
        private Panel offersPanel;
        private Panel manufacturingLevelsPanel;
        private Label manufacturingLevelsValueLabel;
        private Label manufacturingLevelsTextLabel;
        private Panel manufacturingIncreasePanel;
        private Label manufacturingIncreaseValueLabel;
        private Label manufacturingIncreaseTextLabel;
        private Label manufacturingLevelUnitsLabel;
        private string outputFile;

        private ColorsList colors;

        private Animator animator;

        private Stopwatch feedbackWatch;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new InstructionsForm());
        }

        public void NextIteration()
        {
            currentIteration++;
            if (currentIteration >= experimentIterations.Count)
            {
                Console.Beep();
                MessageBox.Show("\"Благодарим, че взехте участие в експеримента\": \n\tМоля, НЕ натискайте бутона ОК преди ръководителят на експеримента да дойде и да отбележи натрупаното от вас общо количество омниум бонум.",
                    "READ Експеримент",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                new Read.MainContainer().Show();
                return;
            }
            PerformIteration();
        }

        private void PerformIteration()
        {
            feedbackWatch.start();
            EnableButtons();
            this.Visible = true;

            ExperimentIteration experimentIteration = experimentIterations[currentIteration];
            SetupEconomicDataPanels(experimentIteration);

            omniumQuontityLabel.Text = omniumQuantity.ToString();

            firstSupplierRealPanel.Visible = false;

            secondSuppliarRealPanel.Visible = false;
            thirdSupplierRealPanel.Visible = false;
            fourthSupplierRealPanel.Visible = false;

            firstSupplierOfferLabel.Text = experimentIteration.Suppliers[0].AdPrice;
            secondSupplierOfferLabel.Text = experimentIteration.Suppliers[1].AdPrice;
            thirdSupplierOfferLabel.Text = experimentIteration.Suppliers[2].AdPrice;
            fourthSupplierOfferLabel.Text = experimentIteration.Suppliers[3].AdPrice;

            firstSuppliarRealLabel.Text = experimentIteration.Suppliers[0].RealPrice;
            secondSuppliarRealLabel.Text = experimentIteration.Suppliers[1].RealPrice;
            thirdSupplierRealLabel.Text = experimentIteration.Suppliers[2].RealPrice;
            fourthSuppliarRealLabel.Text = experimentIteration.Suppliers[3].RealPrice;

            choiceStopwatch.start();
        }

        private void SetupEconomicDataPanels(ExperimentIteration experimentIteration)
        {
            if (experimentIteration.HasEconomicData())
            {
                ShowEconomicDataPanels();
                manufacturingLevelsValueLabel.Text = experimentIteration.GetManufacturingLevels();
                manufacturingIncreaseValueLabel.Text = experimentIteration.GetManufacturingIncrease();
            }
            else
            {
                HideEconomicDataPanels();
            }
        }

        private void HideEconomicDataPanels()
        {
            manufacturingLevelsPanel.Visible = false;
            manufacturingIncreasePanel.Visible = false;
        }

        private void ShowEconomicDataPanels()
        {
            manufacturingLevelsPanel.Visible = true;
            manufacturingIncreasePanel.Visible = true;
        }

        private void FormReadExperiment_Closing(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void DisableButtons()
        {
            firstSuppierBtn.Enabled = false;
            secondSupplierBtn.Enabled = false;
            thirdSupplierBtn.Enabled = false;
            fourthSupplierBtn.Enabled = false;

            nextBtn.Enabled = true;
        }

        private void EnableButtons()
        {
            firstSuppierBtn.Enabled = true;
            secondSupplierBtn.Enabled = true;
            thirdSupplierBtn.Enabled = true;
            fourthSupplierBtn.Enabled = true;

            nextBtn.Enabled = false;
        }

        private void FirstSuppierBtn_Click(object sender, EventArgs e)
        {
            supplierIndx = 0;

            ExperimentIteration it = experimentIterations[currentIteration];

            omniumQuantity += int.Parse(it.Suppliers[supplierIndx].RealPrice);
            omniumQuontityLabel.Text = omniumQuantity.ToString();
            firstSupplierRealPanel.Visible = true;
            DisableButtons();
            nextSwtopwatch.start();
            choiceTime = choiceStopwatch.stop();
        }

        private void SecondSupplierBtn_Click(object sender, EventArgs e)
        {
            supplierIndx = 1;

            ExperimentIteration it = experimentIterations[currentIteration];

            omniumQuantity += int.Parse(it.Suppliers[supplierIndx].RealPrice);
            omniumQuontityLabel.Text = omniumQuantity.ToString();
            secondSuppliarRealPanel.Visible = true;
            DisableButtons();
            nextSwtopwatch.start();
            choiceTime = choiceStopwatch.stop();
        }

        private void ThirdSupplierBtn_Click(object sender, EventArgs e)
        {
            supplierIndx = 2;

            ExperimentIteration it = experimentIterations[currentIteration];

            omniumQuantity += int.Parse(it.Suppliers[supplierIndx].RealPrice);
            omniumQuontityLabel.Text = omniumQuantity.ToString();
            thirdSupplierRealPanel.Visible = true;
            DisableButtons();
            nextSwtopwatch.start();
            choiceTime = choiceStopwatch.stop();

        }

        private void FourthSupplierBtn_Click(object sender, EventArgs e)
        {
            supplierIndx = 3;

            ExperimentIteration it = experimentIterations[currentIteration];

            omniumQuantity += int.Parse(it.Suppliers[supplierIndx].RealPrice);
            omniumQuontityLabel.Text = omniumQuantity.ToString();
            fourthSupplierRealPanel.Visible = true;
            DisableButtons();
            nextSwtopwatch.start();
            choiceTime = choiceStopwatch.stop();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            ExperimentIteration it = experimentIterations[currentIteration];
            DSScaleChoice frm =
                new DSScaleChoice(supplierNames[supplierIndx],
                                  it.Suppliers[supplierIndx].AdPrice,
                                  it.Suppliers[supplierIndx].RealPrice,
                                  omniumQuantity.ToString(),
                                  choiceTime,
                                  nextSwtopwatch.stop(),
                                  outputFile,
                                  this);
            this.Visible = false;
            frm.ShowDialog();
        }
    }
}