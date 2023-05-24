using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.HierarchicalDataSource" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HierarchicalDataSourceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HierarchicalDataSource" />)
        /// </summary>
        public HierarchicalDataSourceTest() : base(typeof(HierarchicalDataSource))
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

        #region General Initializer : Class (HierarchicalDataSource) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _hierarchicalDataSourceInstanceType;
        private HierarchicalDataSource _hierarchicalDataSourceInstance;
        private HierarchicalDataSource _hierarchicalDataSourceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HierarchicalDataSource" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _hierarchicalDataSourceInstanceType = typeof(HierarchicalDataSource);
            _hierarchicalDataSourceInstanceFixture = this.Create<HierarchicalDataSource>(false);
            _hierarchicalDataSourceInstance = _hierarchicalDataSourceInstanceFixture ?? this.Create<HierarchicalDataSource>(true);
            CurrentInstance = _hierarchicalDataSourceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HierarchicalDataSource) Initializer

        #region Properties

        private const string PropertyTreeSource = "TreeSource";

        #endregion

        #region Methods

        private const string MethodFindChildren = "FindChildren";

        #endregion

        #endregion

        #region General Initializer : Class (HierarchicalDataSource) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HierarchicalDataSource" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HierarchicalDataSource_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HierarchicalDataSource) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HierarchicalDataSource" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HierarchicalDataSource_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HierarchicalDataSource) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HierarchicalDataSource" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HierarchicalDataSource_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HierarchicalDataSource)

        #region General Initializer : Class (HierarchicalDataSource) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HierarchicalDataSource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodFindChildren, 0)]
        public void AUT_HierarchicalDataSource_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HierarchicalDataSource) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HierarchicalDataSource" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTreeSource)]
        [Category("AUT Property")]
        public void AUT_HierarchicalDataSource_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HierarchicalDataSource) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HierarchicalDataSource" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HierarchicalDataSource_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _hierarchicalDataSourceInstance.ShouldBeAssignableTo<HierarchicalDataSource>();
            _hierarchicalDataSourceInstanceFixture.ShouldBeAssignableTo<HierarchicalDataSource>();
            CurrentInstance.ShouldBeAssignableTo<HierarchicalDataSource>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (HierarchicalDataSource) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTreeSource)]
        public void AUT_HierarchicalDataSource_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (HierarchicalDataSource) => Property (TreeSource) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HierarchicalDataSource_Public_Class_TreeSource_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTreeSource);
            var propertyInfo = this.GetPropertyInfo(PropertyTreeSource);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (FindChildren) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HierarchicalDataSource_FindChildren_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var item = this.CreateType<TreeData>();
            var methodFindChildrenParametersTypes = new Type[] { typeof(TreeData) };
            object[] parametersOfFindChildren = { item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFindChildren, methodFindChildrenParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_hierarchicalDataSourceInstanceFixture, parametersOfFindChildren);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFindChildren.ShouldNotBeNull();
            parametersOfFindChildren.Length.ShouldBe(1);
            methodFindChildrenParametersTypes.Length.ShouldBe(1);
            methodFindChildrenParametersTypes.Length.ShouldBe(parametersOfFindChildren.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FindChildren) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HierarchicalDataSource_FindChildren_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var item = this.CreateType<TreeData>();
            var methodFindChildrenParametersTypes = new Type[] { typeof(TreeData) };
            object[] parametersOfFindChildren = { item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFindChildren, parametersOfFindChildren, methodFindChildrenParametersTypes);

            // Assert
            parametersOfFindChildren.ShouldNotBeNull();
            parametersOfFindChildren.Length.ShouldBe(1);
            methodFindChildrenParametersTypes.Length.ShouldBe(1);
            methodFindChildrenParametersTypes.Length.ShouldBe(parametersOfFindChildren.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindChildren) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HierarchicalDataSource_FindChildren_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var currentMethodInfo = this.GetMethodInfo(MethodFindChildren, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindChildren) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HierarchicalDataSource_FindChildren_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var methodFindChildrenParametersTypes = new Type[] { typeof(TreeData) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindChildren, methodFindChildrenParametersTypes);

            // Assert
            methodFindChildrenParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindChildren) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HierarchicalDataSource_FindChildren_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var currentMethodInfo = this.GetMethodInfo(MethodFindChildren, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}