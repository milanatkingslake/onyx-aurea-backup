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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.AddContactControl" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class AddContactControlDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="AddContactControlNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public AddContactControlDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: AddContactControlNonPublicTypeName)
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

        private Type _addContactControlInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string AddContactControlNonPublicTypeName = "OnyxOutlookAddin.AddContactControl";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _addContactControlInstance;
        private object _addContactControlInstanceFixture;

        #region General Initializer : Class (AddContactControl) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="AddContactControl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _addContactControlInstanceFixture = this.CreateNonPublicType(AddContactControlNonPublicTypeName);
            _addContactControlInstance = _addContactControlInstanceFixture;
            CurrentInstance = _addContactControlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AddContactControl) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string FieldcontactNameCombo = "contactNameCombo";
        private const string FieldcontactTypeCombo = "contactTypeCombo";
        private const string Fieldlabel1 = "label1";
        private const string FieldlblContactName = "lblContactName";
        private const string FieldlblContactType = "lblContactType";
        private const string FieldcontactExistsLbl = "contactExistsLbl";
        private const string FieldcancelContactBtn = "cancelContactBtn";
        private const string FieldsaveContactBtn = "saveContactBtn";
        private const string FieldsplitContainer1 = "splitContainer1";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (AddContactControl)

        #region General Initializer : Class (AddContactControl) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AddContactControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInitializeComponent, 0)]
        [Category("AUT Explore")]
        public void AUT_AddContactControlDesigner_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AddContactControl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AddContactControl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AddContactControlDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (AddContactControl) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AddContactControl" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [TestCase(FieldcontactNameCombo)]
        [TestCase(FieldcontactTypeCombo)]
        [TestCase(Fieldlabel1)]
        [TestCase(FieldlblContactName)]
        [TestCase(FieldlblContactType)]
        [TestCase(FieldcontactExistsLbl)]
        [TestCase(FieldcancelContactBtn)]
        [TestCase(FieldsaveContactBtn)]
        [TestCase(FieldsplitContainer1)]
        [Category("AUT Fields")]
        public void AUT_AddContactControlDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (AddContactControl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AddContactControl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AddContactControlDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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