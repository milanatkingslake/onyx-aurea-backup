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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.AccessPrivilege" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AccessPrivilegeTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AccessPrivilege" />)
        /// </summary>
        public AccessPrivilegeTest() : base(typeof(AccessPrivilege))
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

        #region General Initializer : Class (AccessPrivilege) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _accessPrivilegeInstanceType;
        private AccessPrivilege _accessPrivilegeInstance;
        private AccessPrivilege _accessPrivilegeInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AccessPrivilege" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _accessPrivilegeInstanceType = typeof(AccessPrivilege);
            _accessPrivilegeInstanceFixture = this.Create<AccessPrivilege>(false);
            _accessPrivilegeInstance = _accessPrivilegeInstanceFixture ?? this.Create<AccessPrivilege>(true);
            CurrentInstance = _accessPrivilegeInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AccessPrivilege) Initializer

        #region Properties

        private const string PropertyStatus = "Status";
        private const string PropertyPLPToken = "PLPToken";
        private const string PropertyAclKey = "AclKey";
        private const string PropertyUser = "User";
        private const string PropertyActiveRole = "ActiveRole";
        private const string PropertyResourceName = "ResourceName";
        private const string PropertyPermission = "Permission";

        #endregion

        #endregion

        #region General Initializer : Class (AccessPrivilege) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AccessPrivilege" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AccessPrivilege_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AccessPrivilege) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="AccessPrivilege" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AccessPrivilege_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AccessPrivilege) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AccessPrivilege" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AccessPrivilege_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AccessPrivilege)

        #region General Initializer : Class (AccessPrivilege) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="AccessPrivilege" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyPLPToken)]
        [TestCase(PropertyAclKey)]
        [TestCase(PropertyUser)]
        [TestCase(PropertyActiveRole)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertyPermission)]
        [Category("AUT Property")]
        public void AUT_AccessPrivilege_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AccessPrivilege) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AccessPrivilege" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AccessPrivilege_Is_Instance_Present_Test()
        {
            // Assert
            _accessPrivilegeInstanceType.ShouldNotBeNull();
            _accessPrivilegeInstance.ShouldNotBeNull();
            _accessPrivilegeInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (AccessPrivilege) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AccessPrivilege" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AccessPrivilege_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _accessPrivilegeInstance.ShouldBeAssignableTo<AccessPrivilege>();
            _accessPrivilegeInstanceFixture.ShouldBeAssignableTo<AccessPrivilege>();
            CurrentInstance.ShouldBeAssignableTo<AccessPrivilege>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (AccessPrivilege) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AccessPrivilege_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            AccessPrivilege instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (AccessPrivilege) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyPLPToken)]
        [TestCase(PropertyAclKey)]
        [TestCase(PropertyUser)]
        [TestCase(PropertyActiveRole)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertyPermission)]
        public void AUT_AccessPrivilege_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (AccessPrivilege) => Property (AclKey) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AccessPrivilege_Public_Class_AclKey_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAclKey);
            var propertyInfo = this.GetPropertyInfo(PropertyAclKey);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AccessPrivilege) => Property (ActiveRole) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AccessPrivilege_Public_Class_ActiveRole_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActiveRole);
            var propertyInfo = this.GetPropertyInfo(PropertyActiveRole);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AccessPrivilege) => Property (Permission) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AccessPrivilege_Public_Class_Permission_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPermission);
            var propertyInfo = this.GetPropertyInfo(PropertyPermission);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AccessPrivilege) => Property (PLPToken) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AccessPrivilege_Public_Class_PLPToken_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPLPToken);
            var propertyInfo = this.GetPropertyInfo(PropertyPLPToken);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AccessPrivilege) => Property (ResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AccessPrivilege_Public_Class_ResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AccessPrivilege) => Property (Status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AccessPrivilege_Public_Class_Status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (AccessPrivilege) => Property (User) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AccessPrivilege_Public_Class_User_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser);
            var propertyInfo = this.GetPropertyInfo(PropertyUser);

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