using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.AccessControlList" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AccessControlListTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AccessControlList" />)
        /// </summary>
        public AccessControlListTest() : base(typeof(AccessControlList))
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

        #region General Initializer : Class (AccessControlList) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _accessControlListInstanceType;
        private AccessControlList _accessControlListInstance;
        private AccessControlList _accessControlListInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AccessControlList" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _accessControlListInstanceType = typeof(AccessControlList);
            _accessControlListInstanceFixture = this.Create<AccessControlList>(false);
            _accessControlListInstance = _accessControlListInstanceFixture ?? this.Create<AccessControlList>(true);
            CurrentInstance = _accessControlListInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AccessControlList) Initializer

        #region Properties

        private const string PropertyAccessControlElementId = "AccessControlElementId";
        private const string PropertyIsViewable = "IsViewable";

        #endregion

        #endregion

        #region General Initializer : Class (AccessControlList) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AccessControlList" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AccessControlList_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AccessControlList) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="AccessControlList" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AccessControlList_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AccessControlList) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AccessControlList" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AccessControlList_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AccessControlList)

        #region General Initializer : Class (AccessControlList) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="AccessControlList" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyAccessControlElementId)]
        [TestCase(PropertyIsViewable)]
        [Category("AUT Property")]
        public void AUT_AccessControlList_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (AccessControlList) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AccessControlList" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AccessControlList_Is_Instance_Present_Test()
        {
            // Assert
            _accessControlListInstanceType.ShouldNotBeNull();
            _accessControlListInstance.ShouldNotBeNull();
            _accessControlListInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (AccessControlList) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AccessControlList" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AccessControlList_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _accessControlListInstance.ShouldBeAssignableTo<AccessControlList>();
            _accessControlListInstanceFixture.ShouldBeAssignableTo<AccessControlList>();
            CurrentInstance.ShouldBeAssignableTo<AccessControlList>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (AccessControlList) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AccessControlList_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            AccessControlList instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (AccessControlList) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyAccessControlElementId)]
        [TestCase(PropertyIsViewable)]
        public void AUT_AccessControlList_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (AccessControlList) => Property (AccessControlElementId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AccessControlList_Public_Class_AccessControlElementId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAccessControlElementId);
            var propertyInfo = this.GetPropertyInfo(PropertyAccessControlElementId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AccessControlList) => Property (IsViewable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AccessControlList_Public_Class_IsViewable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsViewable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsViewable);

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