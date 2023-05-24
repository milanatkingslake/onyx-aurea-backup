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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.CreateIncidentControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CreateIncidentControlDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="CreateIncidentControlNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public CreateIncidentControlDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: CreateIncidentControlNonPublicTypeName)
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

        private Type _createIncidentControlInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string CreateIncidentControlNonPublicTypeName = "OnyxOutlookAddin.CreateIncidentControl";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _createIncidentControlInstance;
        private object _createIncidentControlInstanceFixture;

        #region General Initializer : Class (CreateIncidentControl) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="CreateIncidentControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _createIncidentControlInstanceFixture = this.CreateNonPublicType(CreateIncidentControlNonPublicTypeName);
            _createIncidentControlInstance = _createIncidentControlInstanceFixture;
            CurrentInstance = _createIncidentControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CreateIncidentControl) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string FieldcreateIncidentTitle = "createIncidentTitle";
        private const string FieldlblType = "lblType";
        private const string FieldlblProduct = "lblProduct";
        private const string FieldlblPriority = "lblPriority";
        private const string FieldincidentType = "incidentType";
        private const string FieldincidentProduct = "incidentProduct";
        private const string FieldincidentPriority = "incidentPriority";
        private const string FieldlblDescription = "lblDescription";
        private const string FieldincidentDescription = "incidentDescription";
        private const string FieldcancelIncidentBtn = "cancelIncidentBtn";
        private const string FieldsaveIncidentBtn = "saveIncidentBtn";
        private const string FieldtxtNotes = "txtNotes";
        private const string Fieldlabel2 = "label2";
        private const string FieldchkIncludeEmailAsNote = "chkIncludeEmailAsNote";
        private const string FieldsplitContainer1 = "splitContainer1";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (CreateIncidentControl)

        #region General Initializer : Class (CreateIncidentControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_CreateIncidentControlDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CreateIncidentControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateIncidentControlDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CreateIncidentControl) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateIncidentControlDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CreateIncidentControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [TestCase(FieldcreateIncidentTitle)]
        [TestCase(FieldlblType)]
        [TestCase(FieldlblProduct)]
        [TestCase(FieldlblPriority)]
        [TestCase(FieldincidentType)]
        [TestCase(FieldincidentProduct)]
        [TestCase(FieldincidentPriority)]
        [TestCase(FieldlblDescription)]
        [TestCase(FieldincidentDescription)]
        [TestCase(FieldcancelIncidentBtn)]
        [TestCase(FieldsaveIncidentBtn)]
        [TestCase(FieldtxtNotes)]
        [TestCase(Fieldlabel2)]
        [TestCase(FieldchkIncludeEmailAsNote)]
        [TestCase(FieldsplitContainer1)]
        [Category("AUT Fields")]
        public void AUT_CreateIncidentControlDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CreateIncidentControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CreateIncidentControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateIncidentControlDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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