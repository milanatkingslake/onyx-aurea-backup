using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ItemNamespaceHeader" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ItemNamespaceHeaderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ItemNamespaceHeader" />)
        /// </summary>
        public ItemNamespaceHeaderTest() : base(typeof(ItemNamespaceHeader))
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

        #region General Initializer : Class (ItemNamespaceHeader) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _itemNamespaceHeaderInstanceType;
        private ItemNamespaceHeader _itemNamespaceHeaderInstance;
        private ItemNamespaceHeader _itemNamespaceHeaderInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ItemNamespaceHeader" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _itemNamespaceHeaderInstanceType = typeof(ItemNamespaceHeader);
            _itemNamespaceHeaderInstanceFixture = this.Create<ItemNamespaceHeader>(false);
            _itemNamespaceHeaderInstance = _itemNamespaceHeaderInstanceFixture ?? this.Create<ItemNamespaceHeader>(true);
            CurrentInstance = _itemNamespaceHeaderInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ItemNamespaceHeader) Initializer

        #region Properties

        private const string PropertyItemNamespace = "ItemNamespace";
        private const string PropertyAnyAttr = "AnyAttr";

        #endregion

        #region Fields

        private const string FielditemNamespaceField = "itemNamespaceField";
        private const string FieldanyAttrField = "anyAttrField";

        #endregion

        #endregion

        #region General Initializer : Class (ItemNamespaceHeader) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ItemNamespaceHeader" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ItemNamespaceHeader_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ItemNamespaceHeader) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ItemNamespaceHeader" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ItemNamespaceHeader_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ItemNamespaceHeader) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ItemNamespaceHeader" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ItemNamespaceHeader_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ItemNamespaceHeader)

        #region General Initializer : Class (ItemNamespaceHeader) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ItemNamespaceHeader" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyItemNamespace)]
        [TestCase(PropertyAnyAttr)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ItemNamespaceHeader_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ItemNamespaceHeader) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ItemNamespaceHeader" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FielditemNamespaceField)]
        [TestCase(FieldanyAttrField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ItemNamespaceHeader_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ItemNamespaceHeader) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ItemNamespaceHeader" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ItemNamespaceHeader_Is_Instance_Present_Test()
        {
            // Assert
            _itemNamespaceHeaderInstanceType.ShouldNotBeNull();
            _itemNamespaceHeaderInstance.ShouldNotBeNull();
            _itemNamespaceHeaderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ItemNamespaceHeader) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ItemNamespaceHeader" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ItemNamespaceHeader_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _itemNamespaceHeaderInstance.ShouldBeAssignableTo<ItemNamespaceHeader>();
            _itemNamespaceHeaderInstanceFixture.ShouldBeAssignableTo<ItemNamespaceHeader>();
            CurrentInstance.ShouldBeAssignableTo<ItemNamespaceHeader>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ItemNamespaceHeader) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ItemNamespaceHeader_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ItemNamespaceHeader instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ItemNamespaceHeader) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyItemNamespace)]
        [TestCase(PropertyAnyAttr)]
        public void AUT_ItemNamespaceHeader_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ItemNamespaceHeader) => Property (AnyAttr) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ItemNamespaceHeader_AnyAttr_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAnyAttr);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAnyAttr);
            Action currentAction = () => propertyInfo.SetValue(_itemNamespaceHeaderInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ItemNamespaceHeader) => Property (AnyAttr) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ItemNamespaceHeader_Public_Class_AnyAttr_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAnyAttr);
            var propertyInfo = this.GetPropertyInfo(PropertyAnyAttr);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ItemNamespaceHeader) => Property (ItemNamespace) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ItemNamespaceHeader_ItemNamespace_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemNamespace);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyItemNamespace);
            Action currentAction = () => propertyInfo.SetValue(_itemNamespaceHeaderInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ItemNamespaceHeader) => Property (ItemNamespace) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ItemNamespaceHeader_Public_Class_ItemNamespace_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItemNamespace);
            var propertyInfo = this.GetPropertyInfo(PropertyItemNamespace);

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