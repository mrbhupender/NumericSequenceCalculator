﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace SequenceCalculatorWebApp.Tests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Click on Get Sequences button to generate sequences
        /// </summary>
        public void GenerateSequences()
        {
            #region Variable Declarations
            HtmlEdit uIEnternumberEdit = this.UIV9InternetExplorerWindow.UIHomePageNumericSequeDocument.UIEnternumberEdit;
            HtmlInputButton uIGetSequencesButton = this.UIV9InternetExplorerWindow.UIHomePageNumericSequeDocument.UIGetSequencesButton;
            #endregion

            // Go to web page 'http://localhost:1516/' using new browser instance
            this.UIV9InternetExplorerWindow.LaunchUrl(new System.Uri(this.GenerateSequencesParams.UIV9InternetExplorerWindowUrl));

            // Type '23' in 'Enter number' text box
            uIEnternumberEdit.Text = this.GenerateSequencesParams.UIEnternumberEditText;

            // Click 'GetSequences' button
            Mouse.Click(uIGetSequencesButton, new Point(43, 7));
        }
        
        /// <summary>
        /// Assertion for All Numbers Sequence
        /// </summary>
        public void AllNumbersSequence()
        {
            #region Variable Declarations
            HtmlDiv uIAllNumbers0123456789Pane = this.UIV9InternetExplorerWindow.UIHomePageNumericSequeDocument.UIAllNumbers0123456789Pane;
            #endregion

            // Verify that the 'InnerText' property of 'All Numbers 0,1,2,3,4,5,6,7,8,9,10,11,12' pane equals 'All Numbers 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23 '
            Assert.AreEqual(this.AllNumbersSequenceExpectedValues.UIAllNumbers0123456789PaneInnerText, uIAllNumbers0123456789Pane.InnerText, "All Numbers sequence not generated as expected");
        }
        
        /// <summary>
        /// Assetion for Odd Numbers Sequence
        /// </summary>
        public void OddNumbersSequence()
        {
            #region Variable Declarations
            HtmlDiv uIOddNumbers1357911131Pane = this.UIV9InternetExplorerWindow.UIHomePageNumericSequeDocument.UIOddNumbers1357911131Pane;
            #endregion

            // Verify that the 'InnerText' property of 'Odd Numbers 1,3,5,7,9,11,13,15,17,19,21,' pane equals 'Odd Numbers 1,3,5,7,9,11,13,15,17,19,21,23 '
            Assert.AreEqual(this.OddNumbersSequenceExpectedValues.UIOddNumbers1357911131PaneInnerText, uIOddNumbers1357911131Pane.InnerText, "Odd Numbers not generated as expected");
        }
        
        /// <summary>
        /// Assertion for Even Numbers Sequence
        /// </summary>
        public void EvenNumbersSequence()
        {
            #region Variable Declarations
            HtmlDiv uIEvenNumbers024681012Pane = this.UIV9InternetExplorerWindow.UIHomePageNumericSequeDocument.UIEvenNumbers024681012Pane;
            #endregion

            // Verify that the 'InnerText' property of 'Even Numbers 0,2,4,6,8,10,12,14,16,18,20' pane equals 'Even Numbers 0,2,4,6,8,10,12,14,16,18,20,22 '
            Assert.AreEqual(this.EvenNumbersSequenceExpectedValues.UIEvenNumbers024681012PaneInnerText, uIEvenNumbers024681012Pane.InnerText, "Even Numbers not generated as expected");
        }
        
        /// <summary>
        /// Assertion for Custom Sequence
        /// </summary>
        public void CustomSequence()
        {
            #region Variable Declarations
            HtmlDiv uICustomSequenceZ12C4EPane = this.UIV9InternetExplorerWindow.UIHomePageNumericSequeDocument.UICustomSequenceZ12C4EPane;
            #endregion

            // Verify that the 'InnerText' property of 'Custom Sequence Z,1,2,C,4,E,C,7,8,C,E,11' pane equals 'Custom Sequence Z,1,2,C,4,E,C,7,8,C,E,11,C,13,14,Z,16,17,C,19,E,C,22,23 '
            Assert.AreEqual(this.CustomSequenceExpectedValues.UICustomSequenceZ12C4EPaneInnerText, uICustomSequenceZ12C4EPane.InnerText, "Custom Sequence not generated as expected");
        }
        
        /// <summary>
        /// Assertion for Fibonacci Numbers sequence
        /// </summary>
        public void FibonacciNumbersSequence()
        {
            #region Variable Declarations
            HtmlDiv uIFibonacciNumbers0112Pane = this.UIV9InternetExplorerWindow.UIHomePageNumericSequeDocument.UIFibonacciNumbers0112Pane;
            #endregion

            // Verify that the 'InnerText' property of 'Fibonacci Numbers 0,1,1,2,3,5,8,13,21,34' pane equals 'Fibonacci Numbers 0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765,10946,17711,28657 '
            Assert.AreEqual(this.FibonacciNumbersSequenceExpectedValues.UIFibonacciNumbers0112PaneInnerText, uIFibonacciNumbers0112Pane.InnerText, "Fibonacci Numbers not generated as expected");
        }
        
        #region Properties
        public virtual GenerateSequencesParams GenerateSequencesParams
        {
            get
            {
                if ((this.mGenerateSequencesParams == null))
                {
                    this.mGenerateSequencesParams = new GenerateSequencesParams();
                }
                return this.mGenerateSequencesParams;
            }
        }
        
        public virtual AllNumbersSequenceExpectedValues AllNumbersSequenceExpectedValues
        {
            get
            {
                if ((this.mAllNumbersSequenceExpectedValues == null))
                {
                    this.mAllNumbersSequenceExpectedValues = new AllNumbersSequenceExpectedValues();
                }
                return this.mAllNumbersSequenceExpectedValues;
            }
        }
        
        public virtual OddNumbersSequenceExpectedValues OddNumbersSequenceExpectedValues
        {
            get
            {
                if ((this.mOddNumbersSequenceExpectedValues == null))
                {
                    this.mOddNumbersSequenceExpectedValues = new OddNumbersSequenceExpectedValues();
                }
                return this.mOddNumbersSequenceExpectedValues;
            }
        }
        
        public virtual EvenNumbersSequenceExpectedValues EvenNumbersSequenceExpectedValues
        {
            get
            {
                if ((this.mEvenNumbersSequenceExpectedValues == null))
                {
                    this.mEvenNumbersSequenceExpectedValues = new EvenNumbersSequenceExpectedValues();
                }
                return this.mEvenNumbersSequenceExpectedValues;
            }
        }
        
        public virtual CustomSequenceExpectedValues CustomSequenceExpectedValues
        {
            get
            {
                if ((this.mCustomSequenceExpectedValues == null))
                {
                    this.mCustomSequenceExpectedValues = new CustomSequenceExpectedValues();
                }
                return this.mCustomSequenceExpectedValues;
            }
        }
        
        public virtual FibonacciNumbersSequenceExpectedValues FibonacciNumbersSequenceExpectedValues
        {
            get
            {
                if ((this.mFibonacciNumbersSequenceExpectedValues == null))
                {
                    this.mFibonacciNumbersSequenceExpectedValues = new FibonacciNumbersSequenceExpectedValues();
                }
                return this.mFibonacciNumbersSequenceExpectedValues;
            }
        }
        
        public UIV9InternetExplorerWindow UIV9InternetExplorerWindow
        {
            get
            {
                if ((this.mUIV9InternetExplorerWindow == null))
                {
                    this.mUIV9InternetExplorerWindow = new UIV9InternetExplorerWindow();
                }
                return this.mUIV9InternetExplorerWindow;
            }
        }
        #endregion
        
        #region Fields
        private GenerateSequencesParams mGenerateSequencesParams;
        
        private AllNumbersSequenceExpectedValues mAllNumbersSequenceExpectedValues;
        
        private OddNumbersSequenceExpectedValues mOddNumbersSequenceExpectedValues;
        
        private EvenNumbersSequenceExpectedValues mEvenNumbersSequenceExpectedValues;
        
        private CustomSequenceExpectedValues mCustomSequenceExpectedValues;
        
        private FibonacciNumbersSequenceExpectedValues mFibonacciNumbersSequenceExpectedValues;
        
        private UIV9InternetExplorerWindow mUIV9InternetExplorerWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'GenerateSequences'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class GenerateSequencesParams
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://localhost:1516/' using new browser instance
        /// </summary>
        public string UIV9InternetExplorerWindowUrl = "http://localhost:1516/";
        
        /// <summary>
        /// Type '23' in 'Enter number' text box
        /// </summary>
        public string UIEnternumberEditText = "23";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AllNumbersSequence'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class AllNumbersSequenceExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'All Numbers 0,1,2,3,4,5,6,7,8,9,10,11,12' pane equals 'All Numbers 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23 '
        /// </summary>
        public string UIAllNumbers0123456789PaneInnerText = "All Numbers 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23 ";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'OddNumbersSequence'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class OddNumbersSequenceExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Odd Numbers 1,3,5,7,9,11,13,15,17,19,21,' pane equals 'Odd Numbers 1,3,5,7,9,11,13,15,17,19,21,23 '
        /// </summary>
        public string UIOddNumbers1357911131PaneInnerText = "Odd Numbers 1,3,5,7,9,11,13,15,17,19,21,23 ";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'EvenNumbersSequence'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class EvenNumbersSequenceExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Even Numbers 0,2,4,6,8,10,12,14,16,18,20' pane equals 'Even Numbers 0,2,4,6,8,10,12,14,16,18,20,22 '
        /// </summary>
        public string UIEvenNumbers024681012PaneInnerText = "Even Numbers 0,2,4,6,8,10,12,14,16,18,20,22 ";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'CustomSequence'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class CustomSequenceExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Custom Sequence Z,1,2,C,4,E,C,7,8,C,E,11' pane equals 'Custom Sequence Z,1,2,C,4,E,C,7,8,C,E,11,C,13,14,Z,16,17,C,19,E,C,22,23 '
        /// </summary>
        public string UICustomSequenceZ12C4EPaneInnerText = "Custom Sequence Z,1,2,C,4,E,C,7,8,C,E,11,C,13,14,Z,16,17,C,19,E,C,22,23 ";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'FibonacciNumbersSequence'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class FibonacciNumbersSequenceExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Fibonacci Numbers 0,1,1,2,3,5,8,13,21,34' pane equals 'Fibonacci Numbers 0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765,10946,17711,28657 '
        /// </summary>
        public string UIFibonacciNumbers0112PaneInnerText = "Fibonacci Numbers 0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181" +
            ",6765,10946,17711,28657 ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIV9InternetExplorerWindow : BrowserWindow
    {
        
        public UIV9InternetExplorerWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("v9");
            this.WindowTitles.Add("Blank Page");
            this.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHomePageNumericSequeDocument UIHomePageNumericSequeDocument
        {
            get
            {
                if ((this.mUIHomePageNumericSequeDocument == null))
                {
                    this.mUIHomePageNumericSequeDocument = new UIHomePageNumericSequeDocument(this);
                }
                return this.mUIHomePageNumericSequeDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHomePageNumericSequeDocument mUIHomePageNumericSequeDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHomePageNumericSequeDocument : HtmlDocument
    {
        
        public UIHomePageNumericSequeDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page - Numeric Sequence Calculator";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:1516/";
            this.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIEnternumberEdit
        {
            get
            {
                if ((this.mUIEnternumberEdit == null))
                {
                    this.mUIEnternumberEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIEnternumberEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "InputNumber";
                    this.mUIEnternumberEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "InputNumber";
                    this.mUIEnternumberEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Enter number";
                    this.mUIEnternumberEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIEnternumberEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIEnternumberEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = null;
                    this.mUIEnternumberEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"InputNumber\" id=\"InputNumber\" type";
                    this.mUIEnternumberEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "1";
                    this.mUIEnternumberEdit.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
                    #endregion
                }
                return this.mUIEnternumberEdit;
            }
        }
        
        public HtmlInputButton UIGetSequencesButton
        {
            get
            {
                if ((this.mUIGetSequencesButton == null))
                {
                    this.mUIGetSequencesButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIGetSequencesButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUIGetSequencesButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUIGetSequencesButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "GetSequences";
                    this.mUIGetSequencesButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIGetSequencesButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUIGetSequencesButton.FilterProperties[HtmlButton.PropertyNames.Class] = null;
                    this.mUIGetSequencesButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "type=\"submit\" value=\"GetSequences\"";
                    this.mUIGetSequencesButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "2";
                    this.mUIGetSequencesButton.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
                    #endregion
                }
                return this.mUIGetSequencesButton;
            }
        }
        
        public HtmlDiv UIAllNumbers0123456789Pane
        {
            get
            {
                if ((this.mUIAllNumbers0123456789Pane == null))
                {
                    this.mUIAllNumbers0123456789Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIAllNumbers0123456789Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIAllNumbers0123456789Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIAllNumbers0123456789Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "All Numbers 0,1,2,3,4,5,6,7,8,9,10,11,12";
                    this.mUIAllNumbers0123456789Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIAllNumbers0123456789Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIAllNumbers0123456789Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"padding: 10px;\" word-wrap=\"break-word\"";
                    this.mUIAllNumbers0123456789Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "8";
                    this.mUIAllNumbers0123456789Pane.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
                    #endregion
                }
                return this.mUIAllNumbers0123456789Pane;
            }
        }
        
        public HtmlDiv UIOddNumbers1357911131Pane
        {
            get
            {
                if ((this.mUIOddNumbers1357911131Pane == null))
                {
                    this.mUIOddNumbers1357911131Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIOddNumbers1357911131Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIOddNumbers1357911131Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIOddNumbers1357911131Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Odd Numbers 1,3,5,7,9,11,13,15,17,19,21,";
                    this.mUIOddNumbers1357911131Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIOddNumbers1357911131Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIOddNumbers1357911131Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"padding: 10px;\" word-wrap=\"break-word\"";
                    this.mUIOddNumbers1357911131Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "9";
                    this.mUIOddNumbers1357911131Pane.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
                    #endregion
                }
                return this.mUIOddNumbers1357911131Pane;
            }
        }
        
        public HtmlDiv UIEvenNumbers024681012Pane
        {
            get
            {
                if ((this.mUIEvenNumbers024681012Pane == null))
                {
                    this.mUIEvenNumbers024681012Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIEvenNumbers024681012Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIEvenNumbers024681012Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIEvenNumbers024681012Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Even Numbers 0,2,4,6,8,10,12,14,16,18,20";
                    this.mUIEvenNumbers024681012Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIEvenNumbers024681012Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIEvenNumbers024681012Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"padding: 10px;\" word-wrap=\"break-word\"";
                    this.mUIEvenNumbers024681012Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "10";
                    this.mUIEvenNumbers024681012Pane.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
                    #endregion
                }
                return this.mUIEvenNumbers024681012Pane;
            }
        }
        
        public HtmlDiv UICustomSequenceZ12C4EPane
        {
            get
            {
                if ((this.mUICustomSequenceZ12C4EPane == null))
                {
                    this.mUICustomSequenceZ12C4EPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUICustomSequenceZ12C4EPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUICustomSequenceZ12C4EPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUICustomSequenceZ12C4EPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Custom Sequence Z,1,2,C,4,E,C,7,8,C,E,11";
                    this.mUICustomSequenceZ12C4EPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUICustomSequenceZ12C4EPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUICustomSequenceZ12C4EPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"padding: 10px;\" word-wrap=\"break-word\"";
                    this.mUICustomSequenceZ12C4EPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "11";
                    this.mUICustomSequenceZ12C4EPane.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
                    #endregion
                }
                return this.mUICustomSequenceZ12C4EPane;
            }
        }
        
        public HtmlDiv UIFibonacciNumbers0112Pane
        {
            get
            {
                if ((this.mUIFibonacciNumbers0112Pane == null))
                {
                    this.mUIFibonacciNumbers0112Pane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIFibonacciNumbers0112Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIFibonacciNumbers0112Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIFibonacciNumbers0112Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Fibonacci Numbers 0,1,1,2,3,5,8,13,21,34";
                    this.mUIFibonacciNumbers0112Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIFibonacciNumbers0112Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIFibonacciNumbers0112Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"padding: 10px;\" word-wrap=\"break-word\"";
                    this.mUIFibonacciNumbers0112Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "12";
                    this.mUIFibonacciNumbers0112Pane.WindowTitles.Add("Home Page - Numeric Sequence Calculator");
                    #endregion
                }
                return this.mUIFibonacciNumbers0112Pane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIEnternumberEdit;
        
        private HtmlInputButton mUIGetSequencesButton;
        
        private HtmlDiv mUIAllNumbers0123456789Pane;
        
        private HtmlDiv mUIOddNumbers1357911131Pane;
        
        private HtmlDiv mUIEvenNumbers024681012Pane;
        
        private HtmlDiv mUICustomSequenceZ12C4EPane;
        
        private HtmlDiv mUIFibonacciNumbers0112Pane;
        #endregion
    }
}