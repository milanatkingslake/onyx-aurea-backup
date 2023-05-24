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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.TitleControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class TitleControlDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="TitleControlNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public TitleControlDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: TitleControlNonPublicTypeName)
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

        private Type _titleControlInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string TitleControlNonPublicTypeName = "OnyxOutlookAddin.TitleControl";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _titleControlInstance;
        private object _titleControlInstanceFixture;

        #region General Initializer : Class (TitleControl) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="TitleControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _titleControlInstanceFixture = this.CreateNonPublicType(TitleControlNonPublicTypeName);
            _titleControlInstance = _titleControlInstanceFixture;
            CurrentInstance = _titleControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TitleControl) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string FieldtitleTextBox = "titleTextBox";
        private const string FieldexpandCollapseButton = "expandCollapseButton";
        private const string FieldlineLabel = "lineLabel";
        private const string FieldtableLayoutPanel1 = "tableLayoutPanel1";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (TitleControl)

        #region General Initializer : Class (TitleControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_TitleControlDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (TitleControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TitleControlDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TitleControl) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TitleControlDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TitleControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [TestCase(FieldtitleTextBox)]
        [TestCase(FieldexpandCollapseButton)]
        [TestCase(FieldlineLabel)]
        [TestCase(FieldtableLayoutPanel1)]
        [Category("AUT Fields")]
        public void AUT_TitleControlDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (TitleControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TitleControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TitleControlDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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