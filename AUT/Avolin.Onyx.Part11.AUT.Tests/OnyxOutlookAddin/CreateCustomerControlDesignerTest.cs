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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.CreateCustomerControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CreateCustomerControlDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="CreateCustomerControlNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public CreateCustomerControlDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: CreateCustomerControlNonPublicTypeName)
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

        private Type _createCustomerControlInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string CreateCustomerControlNonPublicTypeName = "OnyxOutlookAddin.CreateCustomerControl";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _createCustomerControlInstance;
        private object _createCustomerControlInstanceFixture;

        #region General Initializer : Class (CreateCustomerControl) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="CreateCustomerControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _createCustomerControlInstanceFixture = this.CreateNonPublicType(CreateCustomerControlNonPublicTypeName);
            _createCustomerControlInstance = _createCustomerControlInstanceFixture;
            CurrentInstance = _createCustomerControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CreateCustomerControl) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string Fieldlabel1 = "label1";
        private const string FieldlblFirstName = "lblFirstName";
        private const string FieldlblLastName = "lblLastName";
        private const string FieldlblEmail = "lblEmail";
        private const string FieldlblCustomerType = "lblCustomerType";
        private const string FieldfirstNameTxtBox = "firstNameTxtBox";
        private const string FieldlastNameTxtBox = "lastNameTxtBox";
        private const string FieldemailTextBox = "emailTextBox";
        private const string FieldcustomerTypeCombo = "customerTypeCombo";
        private const string FieldlblPhone = "lblPhone";
        private const string FieldphoneTypeCombo = "phoneTypeCombo";
        private const string FieldexistsinOutlookLbl = "existsinOutlookLbl";
        private const string FieldphoneTextBox = "phoneTextBox";
        private const string FieldsaveCustomerBtn = "saveCustomerBtn";
        private const string FieldbtnPrefCancel = "btnPrefCancel";
        private const string FieldlblCompanyName = "lblCompanyName";
        private const string FieldcompanyCombo = "companyCombo";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (CreateCustomerControl)

        #region General Initializer : Class (CreateCustomerControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CreateCustomerControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_CreateCustomerControlDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CreateCustomerControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CreateCustomerControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateCustomerControlDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CreateCustomerControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CreateCustomerControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [TestCase(Fieldlabel1)]
        [TestCase(FieldlblFirstName)]
        [TestCase(FieldlblLastName)]
        [TestCase(FieldlblEmail)]
        [TestCase(FieldlblCustomerType)]
        [TestCase(FieldfirstNameTxtBox)]
        [TestCase(FieldlastNameTxtBox)]
        [TestCase(FieldemailTextBox)]
        [TestCase(FieldcustomerTypeCombo)]
        [TestCase(FieldlblPhone)]
        [TestCase(FieldphoneTypeCombo)]
        [TestCase(FieldexistsinOutlookLbl)]
        [TestCase(FieldphoneTextBox)]
        [TestCase(FieldsaveCustomerBtn)]
        [TestCase(FieldbtnPrefCancel)]
        [TestCase(FieldlblCompanyName)]
        [TestCase(FieldcompanyCombo)]
        [Category("AUT Fields")]
        public void AUT_CreateCustomerControlDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CreateCustomerControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CreateCustomerControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CreateCustomerControlDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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