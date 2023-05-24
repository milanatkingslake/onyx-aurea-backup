using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.FormMain" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class FormMainDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="FormMainNonPublicTypeName" />) using
        ///     Using a public type <see cref="Constants" /> to
        ///     create a non-public type.
        /// </summary>
        public FormMainDesignerTest() : base(publicType: typeof(Constants), classNameWithNamespace: FormMainNonPublicTypeName)
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        private Type _formMainInstanceType;
        
        private const string FormMainNonPublicTypeName = "Onyx.Ucf.FormMain";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _formMainInstance;
        private object _formMainInstanceFixture;

        #region General Initializer : Class (FormMain) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="FormMain" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _formMainInstanceFixture = this.CreateNonPublicType(FormMainNonPublicTypeName);
            _formMainInstance = _formMainInstanceFixture;
            CurrentInstance = _formMainInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FormMain) Initializer

        #region Methods

        private const string MethodDispose = "Dispose";
        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string FieldbuttonMerge = "buttonMerge";
        private const string Fieldlabel1 = "label1";
        private const string Fieldlabel2 = "label2";
        private const string FieldcomboBoxSourceType = "comboBoxSourceType";
        private const string FieldtextBoxSourceUri = "textBoxSourceUri";
        private const string FieldtextBoxContextString = "textBoxContextString";
        private const string Fieldlabel3 = "label3";
        private const string FieldtextBoxRootPath = "textBoxRootPath";
        private const string Fieldlabel4 = "label4";
        private const string FieldtextBoxPofileId = "textBoxPofileId";
        private const string Fieldlabel5 = "label5";
        private const string FieldcheckBoxPersist = "checkBoxPersist";
        private const string FieldcheckBoxVirtualSource = "checkBoxVirtualSource";
        private const string FieldcheckBoxIncludeCurrentLayer = "checkBoxIncludeCurrentLayer";
        private const string FieldcheckBoxProductionMode = "checkBoxProductionMode";
        private const string FieldcomboBoxEscapeTypes = "comboBoxEscapeTypes";
        private const string Fieldlabel6 = "label6";
        private const string FieldwebBrowserBefore = "webBrowserBefore";
        private const string FieldtabControl = "tabControl";
        private const string FieldtabPage1 = "tabPage1";
        private const string FieldtabPage2 = "tabPage2";
        private const string FieldwebBrowserAfter = "webBrowserAfter";
        private const string FieldtabPage3 = "tabPage3";
        private const string FieldtabPage4 = "tabPage4";
        private const string FieldtextBoxBefore = "textBoxBefore";
        private const string FieldtextBoxAfter = "textBoxAfter";
        private const string FieldtabPage5 = "tabPage5";
        private const string FieldtextBoxActionXml = "textBoxActionXml";
        private const string FieldbuttonAddActions = "buttonAddActions";
        private const string FieldbuttonDiscard = "buttonDiscard";
        private const string FieldbuttonSave = "buttonSave";
        private const string FieldtextBoxVirtualRootXml = "textBoxVirtualRootXml";
        private const string Fieldlabel7 = "label7";
        private const string FieldcheckBoxDisplayHtml = "checkBoxDisplayHtml";
        private const string FieldtextBoxEditSessionId = "textBoxEditSessionId";
        private const string Fieldlabel8 = "label8";
        private const string FieldbuttonCompilePage = "buttonCompilePage";
        private const string FieldbuttonCompileSite = "buttonCompileSite";
        private const string FieldtextBoxComment = "textBoxComment";
        private const string Fieldlabel9 = "label9";

        #endregion

        #endregion

        #endregion

        #endregion
    }
}