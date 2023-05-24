using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Private.Metadata;
using OnyxSDK.Public.Interface.Metadata;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Private.Metadata
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.LboPropertyConstraint" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class LboPropertyConstraintTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboPropertyConstraint" />)
        /// </summary>
        public LboPropertyConstraintTest() : base(typeof(LboPropertyConstraint))
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

        #region General Initializer : Class (LboPropertyConstraint) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboPropertyConstraintInstanceType;
        private LboPropertyConstraint _lboPropertyConstraintInstance;
        private LboPropertyConstraint _lboPropertyConstraintInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LboPropertyConstraint" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboPropertyConstraintInstanceType = typeof(LboPropertyConstraint);
            _lboPropertyConstraintInstanceFixture = this.Create<LboPropertyConstraint>(false);
            _lboPropertyConstraintInstance = _lboPropertyConstraintInstanceFixture ?? this.Create<LboPropertyConstraint>(true);
            CurrentInstance = _lboPropertyConstraintInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboPropertyConstraint) Initializer

        #region Methods

        private const string MethodGetLboObject = "GetLboObject";
        private const string MethodGetLboProperty = "GetLboProperty";

        #endregion

        #endregion

        #region General Initializer : Class (LboPropertyConstraint) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboPropertyConstraint" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboPropertyConstraint_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboPropertyConstraint) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="LboPropertyConstraint" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboPropertyConstraint_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboPropertyConstraint) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboPropertyConstraint" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboPropertyConstraint_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboPropertyConstraint)

        #region General Initializer : Class (LboPropertyConstraint) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboPropertyConstraint" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetLboObject, 0)]
        [TestCase(MethodGetLboProperty, 0)]
        public void AUT_LboPropertyConstraint_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (LboPropertyConstraint) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LboPropertyConstraint" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboPropertyConstraint_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _lboPropertyConstraintInstance.ShouldBeAssignableTo<LboPropertyConstraint>();
            _lboPropertyConstraintInstanceFixture.ShouldBeAssignableTo<LboPropertyConstraint>();
            CurrentInstance.ShouldBeAssignableTo<LboPropertyConstraint>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetLboObject) (Return Type : ILboObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboObject_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            Type [] methodGetLboObjectParametersTypes = null;
            object[] parametersOfGetLboObject = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObject, methodGetLboObjectParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ILboObject>(_lboPropertyConstraintInstanceFixture, parametersOfGetLboObject);
            var result2 = this.GetResultOfMethod<ILboObject>(MethodGetLboObject, parametersOfGetLboObject, methodGetLboObjectParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboObject.ShouldBeNull();
            methodGetLboObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboObject_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            Type [] methodGetLboObjectParametersTypes = null;
            object[] parametersOfGetLboObject = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<ILboObject>(MethodGetLboObject, parametersOfGetLboObject, methodGetLboObjectParametersTypes);

            // Assert
            parametersOfGetLboObject.ShouldBeNull();
            methodGetLboObjectParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboObject_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            Type [] methodGetLboObjectParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboObject, methodGetLboObjectParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboObject_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            Type [] methodGetLboObjectParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboObject, methodGetLboObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboObjectParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObject) (Return Type : ILboObject) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboObject_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboProperty) (Return Type : ILboProperty) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboPropertyConstraint_GetLboProperty_Method_Call_Internally(Type[] types)
        {
            var methodGetLboPropertyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboProperty, methodGetLboPropertyParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboProperty) (Return Type : ILboProperty) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboProperty_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboProperty);
            Type [] methodGetLboPropertyParametersTypes = null;
            object[] parametersOfGetLboProperty = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboProperty, methodGetLboPropertyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ILboProperty>(_lboPropertyConstraintInstanceFixture, parametersOfGetLboProperty);
            var result2 = this.GetResultOfMethod<ILboProperty>(MethodGetLboProperty, parametersOfGetLboProperty, methodGetLboPropertyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboProperty.ShouldBeNull();
            methodGetLboPropertyParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboProperty) (Return Type : ILboProperty) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboProperty_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboProperty);
            Type [] methodGetLboPropertyParametersTypes = null;
            object[] parametersOfGetLboProperty = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<ILboProperty>(MethodGetLboProperty, parametersOfGetLboProperty, methodGetLboPropertyParametersTypes);

            // Assert
            parametersOfGetLboProperty.ShouldBeNull();
            methodGetLboPropertyParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboProperty) (Return Type : ILboProperty) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboProperty_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboProperty);
            Type [] methodGetLboPropertyParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboProperty, methodGetLboPropertyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboPropertyParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboProperty) (Return Type : ILboProperty) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboProperty_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboProperty);
            Type [] methodGetLboPropertyParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboProperty, methodGetLboPropertyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboPropertyParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboProperty) (Return Type : ILboProperty) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboPropertyConstraint_GetLboProperty_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboProperty);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboProperty, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}