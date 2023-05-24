using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Private.Metadata;
using OnyxSDK.Public.Interface;
using OnyxSDK.Public.Interface.Metadata;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Private.Metadata
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.LboProperty" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class LboPropertyTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboProperty" />)
        /// </summary>
        public LboPropertyTest() : base(typeof(LboProperty))
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

        #region General Initializer : Class (LboProperty) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboPropertyInstanceType;
        private LboProperty _lboPropertyInstance;
        private LboProperty _lboPropertyInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LboProperty" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboPropertyInstanceType = typeof(LboProperty);
            _lboPropertyInstanceFixture = this.Create<LboProperty>(false);
            _lboPropertyInstance = _lboPropertyInstanceFixture ?? this.Create<LboProperty>(true);
            CurrentInstance = _lboPropertyInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboProperty) Initializer

        #region Methods

        private const string MethodGetPropertyConstraints = "GetPropertyConstraints";

        #endregion

        #region Fields

        private const string Field_iLog = "_iLog";

        #endregion

        #endregion

        #region General Initializer : Class (LboProperty) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboProperty" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboProperty_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboProperty) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="LboProperty" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboProperty_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboProperty) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboProperty" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboProperty_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboProperty)

        #region General Initializer : Class (LboProperty) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboProperty" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetPropertyConstraints, 0)]
        public void AUT_LboProperty_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (LboProperty) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboProperty" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_iLog)]
        [Category("AUT Fields")]
        public void AUT_LboProperty_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboProperty) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LboProperty" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboProperty_Is_Instance_Present_Test()
        {
            // Assert
            _lboPropertyInstanceType.ShouldNotBeNull();
            _lboPropertyInstance.ShouldNotBeNull();
            _lboPropertyInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (LboProperty) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LboProperty" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboProperty_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _lboPropertyInstance.ShouldBeAssignableTo<LboProperty>();
            _lboPropertyInstanceFixture.ShouldBeAssignableTo<LboProperty>();
            CurrentInstance.ShouldBeAssignableTo<LboProperty>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetPropertyConstraints) (Return Type : IList<ILboPropertyConstraint>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboProperty_GetPropertyConstraints_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetPropertyConstraints = { onyxUserContext };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboPropertyConstraint>>(_lboPropertyInstanceFixture, parametersOfGetPropertyConstraints);
            var result2 = this.GetResultOfMethod<IList<ILboPropertyConstraint>>(MethodGetPropertyConstraints, parametersOfGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetPropertyConstraints.ShouldNotBeNull();
            parametersOfGetPropertyConstraints.Length.ShouldBe(1);
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : IList<ILboPropertyConstraint>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboProperty_GetPropertyConstraints_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetPropertyConstraints = { onyxUserContext };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ILboPropertyConstraint>>(_lboPropertyInstanceFixture, out exception1, parametersOfGetPropertyConstraints);
            var result2 = this.GetResultOfMethod<IList<ILboPropertyConstraint>>(MethodGetPropertyConstraints, parametersOfGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetPropertyConstraints.ShouldNotBeNull();
            parametersOfGetPropertyConstraints.Length.ShouldBe(1);
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : IList<ILboPropertyConstraint>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboProperty_GetPropertyConstraints_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetPropertyConstraints = { onyxUserContext };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboPropertyInstanceFixture, parametersOfGetPropertyConstraints);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetPropertyConstraints.ShouldNotBeNull();
            parametersOfGetPropertyConstraints.Length.ShouldBe(1);
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : IList<ILboPropertyConstraint>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboProperty_GetPropertyConstraints_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var onyxUserContext = this.CreateType<IOnyxUserContext>();
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            object[] parametersOfGetPropertyConstraints = { onyxUserContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ILboPropertyConstraint>>(MethodGetPropertyConstraints, parametersOfGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            parametersOfGetPropertyConstraints.ShouldNotBeNull();
            parametersOfGetPropertyConstraints.Length.ShouldBe(1);
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : IList<ILboPropertyConstraint>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboProperty_GetPropertyConstraints_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : IList<ILboPropertyConstraint>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboProperty_GetPropertyConstraints_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(IOnyxUserContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : IList<ILboPropertyConstraint>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboProperty_GetPropertyConstraints_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var methodGetPropertyConstraintsParametersTypes = new Type[] { typeof(IOnyxUserContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPropertyConstraints, methodGetPropertyConstraintsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPropertyConstraintsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : IList<ILboPropertyConstraint>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboProperty_GetPropertyConstraints_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyConstraints, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetPropertyConstraints) (Return Type : IList<ILboPropertyConstraint>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboProperty_GetPropertyConstraints_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyConstraints);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyConstraints, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}