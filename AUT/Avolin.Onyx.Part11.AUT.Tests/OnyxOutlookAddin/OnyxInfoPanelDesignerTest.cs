using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OnyxInfoPanel" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxInfoPanelDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxInfoPanelNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxInfoPanelDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: OnyxInfoPanelNonPublicTypeName)
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

        private Type _onyxInfoPanelInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OnyxInfoPanelNonPublicTypeName = "OnyxOutlookAddin.OnyxInfoPanel";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _onyxInfoPanelInstance;
        private object _onyxInfoPanelInstanceFixture;

        #region General Initializer : Class (OnyxInfoPanel) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxInfoPanel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxInfoPanelInstanceFixture = this.CreateNonPublicType(OnyxInfoPanelNonPublicTypeName);
            _onyxInfoPanelInstance = _onyxInfoPanelInstanceFixture;
            CurrentInstance = _onyxInfoPanelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxInfoPanel) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string FieldsearchInOnyx = "searchInOnyx";
        private const string FieldsearchButton = "searchButton";
        private const string FieldnotificationBox = "notificationBox";
        private const string FieldcustomerInfoPanel = "customerInfoPanel";
        private const string FieldtrackInOnyxBtn = "trackInOnyxBtn";
        private const string FieldresetBtn = "resetBtn";
        private const string FieldbulkInsertBtn = "bulkInsertBtn";
        private const string FieldpickContactsBtn = "pickContactsBtn";
        private const string FieldpageControlPanel = "pageControlPanel";
        private const string FieldmultiPageContextMenuNext = "multiPageContextMenuNext";
        private const string FieldsplitContainer1 = "splitContainer1";
        private const string FieldsplitContainer2 = "splitContainer2";
        private const string FieldmultiPageContextMenuPrev = "multiPageContextMenuPrev";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxInfoPanel)

        #region General Initializer : Class (OnyxInfoPanel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_OnyxInfoPanelDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (OnyxInfoPanel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxInfoPanelDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OnyxInfoPanel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxInfoPanelDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OnyxInfoPanel) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [TestCase(FieldsearchInOnyx)]
        [TestCase(FieldsearchButton)]
        [TestCase(FieldnotificationBox)]
        [TestCase(FieldcustomerInfoPanel)]
        [TestCase(FieldtrackInOnyxBtn)]
        [TestCase(FieldresetBtn)]
        [TestCase(FieldbulkInsertBtn)]
        [TestCase(FieldpickContactsBtn)]
        [TestCase(FieldpageControlPanel)]
        [TestCase(FieldmultiPageContextMenuNext)]
        [TestCase(FieldsplitContainer1)]
        [TestCase(FieldsplitContainer2)]
        [TestCase(FieldmultiPageContextMenuPrev)]
        [Category("AUT Fields")]
        public void AUT_OnyxInfoPanelDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (OnyxInfoPanel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxInfoPanel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxInfoPanelDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}