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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.AddinSettings" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class AddinSettingsDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="AddinSettingsNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public AddinSettingsDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: AddinSettingsNonPublicTypeName)
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

        private Type _addinSettingsInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string AddinSettingsNonPublicTypeName = "OnyxOutlookAddin.AddinSettings";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _addinSettingsInstance;
        private object _addinSettingsInstanceFixture;

        #region General Initializer : Class (AddinSettings) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="AddinSettings" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _addinSettingsInstanceFixture = this.CreateNonPublicType(AddinSettingsNonPublicTypeName);
            _addinSettingsInstance = _addinSettingsInstanceFixture;
            CurrentInstance = _addinSettingsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AddinSettings) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string FieldtoolStripContainer1 = "toolStripContainer1";
        private const string FieldtoolStrip1 = "toolStrip1";
        private const string FieldtslAddinSettings = "tslAddinSettings";
        private const string FieldflowSettingsLayoutPanel = "flowSettingsLayoutPanel";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (AddinSettings)

        #region General Initializer : Class (AddinSettings) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AddinSettings" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_AddinSettingsDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AddinSettings) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AddinSettings" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AddinSettingsDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (AddinSettings) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AddinSettings" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [TestCase(FieldtoolStripContainer1)]
        [TestCase(FieldtoolStrip1)]
        [TestCase(FieldtslAddinSettings)]
        [TestCase(FieldflowSettingsLayoutPanel)]
        [Category("AUT Fields")]
        public void AUT_AddinSettingsDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (AddinSettings) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AddinSettings" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AddinSettingsDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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