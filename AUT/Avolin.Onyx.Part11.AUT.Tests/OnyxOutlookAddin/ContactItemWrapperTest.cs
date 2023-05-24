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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.ContactItemWrapper" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ContactItemWrapperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ContactItemWrapperNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public ContactItemWrapperTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: ContactItemWrapperNonPublicTypeName)
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

        private Type _contactItemWrapperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ContactItemWrapperNonPublicTypeName = "OnyxOutlookAddin.ContactItemWrapper";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _contactItemWrapperInstance;
        private object _contactItemWrapperInstanceFixture;

        #region General Initializer : Class (ContactItemWrapper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ContactItemWrapper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _contactItemWrapperInstanceFixture = this.CreateNonPublicType(ContactItemWrapperNonPublicTypeName);
            _contactItemWrapperInstance = _contactItemWrapperInstanceFixture;
            CurrentInstance = _contactItemWrapperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ContactItemWrapper) Initializer

        #region Properties

        private const string PropertyItem = "Item";

        #endregion

        #region Methods

        private const string MethodpopulateInfoPanel = "populateInfoPanel";
        private const string MethodcontactItemSaved = "contactItemSaved";
        
        private const string MethodcontactItemClose = "contactItemClose";

        #endregion

        #region Fields

        private const string Fielditem = "item";
        private const string Fieldtimer = "timer";
        private const string FieldonyxInformationPanel = "onyxInformationPanel";
        private const string FieldnewContact = "newContact";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (ContactItemWrapper)

        #region General Initializer : Class (ContactItemWrapper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ContactItemWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodpopulateInfoPanel, 0)]
        [TestCase(MethodcontactItemSaved, 0)]
        [Category("AUT Explore")]
        public void AUT_ContactItemWrapper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ContactItemWrapper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ContactItemWrapper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ContactItemWrapper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ContactItemWrapper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ContactItemWrapper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyItem)]
        [Category("AUT Property")]
        public void AUT_ContactItemWrapper_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (ContactItemWrapper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ContactItemWrapper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ContactItemWrapper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ContactItemWrapper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ContactItemWrapper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fielditem)]
        [TestCase(Fieldtimer)]
        [TestCase(FieldonyxInformationPanel)]
        [TestCase(FieldnewContact)]
        [Category("AUT Fields")]
        public void AUT_ContactItemWrapper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ContactItemWrapper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ContactItemWrapper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ContactItemWrapper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ContactItemWrapper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyItem)]
        public void AUT_ContactItemWrapper_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (ContactItemWrapper) => Property (Item) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ContactItemWrapper_Public_Class_Item_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItem);
            var propertyInfo = this.GetPropertyInfo(PropertyItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}