using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ObjectGenerator" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ObjectGeneratorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ObjectGenerator" />)
        /// </summary>
        public ObjectGeneratorTest() : base(typeof(ObjectGenerator))
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

        #region General Initializer : Class (ObjectGenerator) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _objectGeneratorInstanceType;
        private ObjectGenerator _objectGeneratorInstance;
        private ObjectGenerator _objectGeneratorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ObjectGenerator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _objectGeneratorInstanceType = typeof(ObjectGenerator);
            _objectGeneratorInstanceFixture = this.Create<ObjectGenerator>(false);
            _objectGeneratorInstance = _objectGeneratorInstanceFixture ?? this.Create<ObjectGenerator>(true);
            CurrentInstance = _objectGeneratorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ObjectGenerator) Initializer

        #region Methods

        private const string MethodGenerateObject = "GenerateObject";
        private const string MethodGenerateGenericType = "GenerateGenericType";
        private const string MethodGenerateTuple = "GenerateTuple";
        private const string MethodIsTuple = "IsTuple";
        private const string MethodGenerateKeyValuePair = "GenerateKeyValuePair";
        private const string MethodGenerateArray = "GenerateArray";
        private const string MethodGenerateDictionary = "GenerateDictionary";
        private const string MethodGenerateEnum = "GenerateEnum";
        private const string MethodGenerateQueryable = "GenerateQueryable";
        private const string MethodGenerateCollection = "GenerateCollection";
        private const string MethodGenerateNullable = "GenerateNullable";
        private const string MethodGenerateComplexObject = "GenerateComplexObject";
        private const string MethodSetPublicProperties = "SetPublicProperties";
        private const string MethodSetPublicFields = "SetPublicFields";

        #endregion

        #region Fields

        private const string FieldSimpleObjectGenerator = "SimpleObjectGenerator";

        #endregion

        #endregion

        #region General Initializer : Class (ObjectGenerator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ObjectGenerator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ObjectGenerator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ObjectGenerator) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ObjectGenerator" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ObjectGenerator_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ObjectGenerator)

        #region General Initializer : Class (ObjectGenerator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ObjectGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGenerateObject, 0)]
        [TestCase(MethodGenerateObject, 1)]
        [TestCase(MethodGenerateGenericType, 0)]
        [TestCase(MethodGenerateTuple, 0)]
        [TestCase(MethodIsTuple, 0)]
        [TestCase(MethodGenerateKeyValuePair, 0)]
        [TestCase(MethodGenerateArray, 0)]
        [TestCase(MethodGenerateDictionary, 0)]
        [TestCase(MethodGenerateEnum, 0)]
        [TestCase(MethodGenerateQueryable, 0)]
        [TestCase(MethodGenerateCollection, 0)]
        [TestCase(MethodGenerateNullable, 0)]
        [TestCase(MethodGenerateComplexObject, 0)]
        [TestCase(MethodSetPublicProperties, 0)]
        [TestCase(MethodSetPublicFields, 0)]
        public void AUT_ObjectGenerator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ObjectGenerator) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ObjectGenerator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldSimpleObjectGenerator)]
        [Category("AUT Fields")]
        public void AUT_ObjectGenerator_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ObjectGenerator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ObjectGenerator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ObjectGenerator_Is_Instance_Present_Test()
        {
            // Assert
            _objectGeneratorInstanceType.ShouldNotBeNull();
            _objectGeneratorInstance.ShouldNotBeNull();
            _objectGeneratorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ObjectGenerator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ObjectGenerator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ObjectGenerator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _objectGeneratorInstance.ShouldBeAssignableTo<ObjectGenerator>();
            _objectGeneratorInstanceFixture.ShouldBeAssignableTo<ObjectGenerator>();
            CurrentInstance.ShouldBeAssignableTo<ObjectGenerator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ObjectGenerator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectGenerator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ObjectGenerator instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GenerateObject) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateObject_Method_Call_Internally(Type[] types)
        {
            var methodGenerateObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateObject, methodGenerateObjectParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var type = this.CreateType<Type>();

            // Act
            Action executeAction = () => _objectGeneratorInstance.GenerateObject(type);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var type = this.CreateType<Type>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _objectGeneratorInstance.GenerateObject(type);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var type = this.CreateType<Type>();
            var methodGenerateObjectParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateObject = { type };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateObject, methodGenerateObjectParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_objectGeneratorInstanceFixture, out exception1, parametersOfGenerateObject);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateObject, parametersOfGenerateObject, methodGenerateObjectParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGenerateObject.ShouldNotBeNull();
            parametersOfGenerateObject.Length.ShouldBe(1);
            methodGenerateObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var type = this.CreateType<Type>();
            var methodGenerateObjectParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateObject = { type };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateObject, methodGenerateObjectParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfGenerateObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateObject.ShouldNotBeNull();
            parametersOfGenerateObject.Length.ShouldBe(1);
            methodGenerateObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var type = this.CreateType<Type>();
            var methodGenerateObjectParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateObject = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateObject, parametersOfGenerateObject, methodGenerateObjectParametersTypes);

            // Assert
            parametersOfGenerateObject.ShouldNotBeNull();
            parametersOfGenerateObject.Length.ShouldBe(1);
            methodGenerateObjectParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var methodGenerateObjectParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateObject, methodGenerateObjectParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGenerateObjectParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var methodGenerateObjectParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateObject, methodGenerateObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateObject, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateObject_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGenerateObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateObject, methodGenerateObjectParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var type = this.CreateType<Type>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateObjectParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateObject = { type, createdObjectReferences };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateObject, methodGenerateObjectParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_objectGeneratorInstanceFixture, parametersOfGenerateObject);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateObject, parametersOfGenerateObject, methodGenerateObjectParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateObject.ShouldNotBeNull();
            parametersOfGenerateObject.Length.ShouldBe(2);
            methodGenerateObjectParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var type = this.CreateType<Type>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateObjectParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateObject = { type, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateObject, parametersOfGenerateObject, methodGenerateObjectParametersTypes);

            // Assert
            parametersOfGenerateObject.ShouldNotBeNull();
            parametersOfGenerateObject.Length.ShouldBe(2);
            methodGenerateObjectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var methodGenerateObjectParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateObject, methodGenerateObjectParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGenerateObjectParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var methodGenerateObjectParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateObject, methodGenerateObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateObject, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GenerateObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateObject_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateObject, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateGenericType) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateGenericType_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateGenericTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateGenericType, methodGenerateGenericTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateGenericType) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateGenericType_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateGenericType);
            var type = this.CreateType<Type>();
            var collectionSize = this.CreateType<int>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateGenericTypeParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateGenericType = { type, collectionSize, createdObjectReferences };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateGenericType, methodGenerateGenericTypeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateGenericType, methodGenerateGenericTypeParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateGenericType, parametersOfGenerateGenericType, methodGenerateGenericTypeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfGenerateGenericType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateGenericType.ShouldNotBeNull();
            parametersOfGenerateGenericType.Length.ShouldBe(3);
            methodGenerateGenericTypeParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateGenericType) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateGenericType_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateGenericType);
            var type = this.CreateType<Type>();
            var collectionSize = this.CreateType<int>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateGenericTypeParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateGenericType = { type, collectionSize, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateGenericType, parametersOfGenerateGenericType, methodGenerateGenericTypeParametersTypes);

            // Assert
            parametersOfGenerateGenericType.ShouldNotBeNull();
            parametersOfGenerateGenericType.Length.ShouldBe(3);
            methodGenerateGenericTypeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateGenericType) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateGenericType_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateGenericType);
            var methodGenerateGenericTypeParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateGenericType, methodGenerateGenericTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateGenericTypeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GenerateGenericType) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateGenericType_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateGenericType);
            var methodGenerateGenericTypeParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateGenericType, methodGenerateGenericTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateGenericTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateGenericType) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateGenericType_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateGenericType);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateGenericType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateGenericType) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateGenericType_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateGenericType);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateGenericType, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateTuple) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateTuple_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateTupleParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateTuple, methodGenerateTupleParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateTuple) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateTuple_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateTuple);
            var type = this.CreateType<Type>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateTupleParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateTuple = { type, createdObjectReferences };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateTuple, methodGenerateTupleParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateTuple, methodGenerateTupleParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateTuple, parametersOfGenerateTuple, methodGenerateTupleParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfGenerateTuple);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateTuple.ShouldNotBeNull();
            parametersOfGenerateTuple.Length.ShouldBe(2);
            methodGenerateTupleParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateTuple) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateTuple_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateTuple);
            var type = this.CreateType<Type>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateTupleParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateTuple = { type, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateTuple, parametersOfGenerateTuple, methodGenerateTupleParametersTypes);

            // Assert
            parametersOfGenerateTuple.ShouldNotBeNull();
            parametersOfGenerateTuple.Length.ShouldBe(2);
            methodGenerateTupleParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateTuple) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateTuple_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateTuple);
            var methodGenerateTupleParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateTuple, methodGenerateTupleParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateTupleParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateTuple) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateTuple_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateTuple);
            var methodGenerateTupleParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateTuple, methodGenerateTupleParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateTupleParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateTuple) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateTuple_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateTuple);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateTuple, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateTuple) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateTuple_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateTuple);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateTuple, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsTuple) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_IsTuple_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsTupleParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsTuple, methodIsTupleParametersTypes);
        }

        #endregion

        #region Method Call : (IsTuple) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_IsTuple_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTuple);
            var genericTypeDefinition = this.CreateType<Type>();
            var methodIsTupleParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsTuple = { genericTypeDefinition };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsTuple, methodIsTupleParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsTuple, methodIsTupleParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsTuple, parametersOfIsTuple, methodIsTupleParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsTuple.ShouldNotBeNull();
            parametersOfIsTuple.Length.ShouldBe(1);
            methodIsTupleParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsTuple, parametersOfIsTuple, methodIsTupleParametersTypes));
        }

        #endregion

        #region Method Call : (IsTuple) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_IsTuple_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTuple);
            var genericTypeDefinition = this.CreateType<Type>();
            var methodIsTupleParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsTuple = { genericTypeDefinition };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsTuple, methodIsTupleParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfIsTuple);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsTuple.ShouldNotBeNull();
            parametersOfIsTuple.Length.ShouldBe(1);
            methodIsTupleParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsTuple) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_IsTuple_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTuple);
            var genericTypeDefinition = this.CreateType<Type>();
            var methodIsTupleParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfIsTuple = { genericTypeDefinition };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsTuple, parametersOfIsTuple, methodIsTupleParametersTypes);

            // Assert
            parametersOfIsTuple.ShouldNotBeNull();
            parametersOfIsTuple.Length.ShouldBe(1);
            methodIsTupleParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsTuple) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_IsTuple_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTuple);
            var methodIsTupleParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsTuple, methodIsTupleParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsTupleParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsTuple) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_IsTuple_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTuple);
            var methodIsTupleParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsTuple, methodIsTupleParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsTupleParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsTuple) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_IsTuple_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTuple);
            var methodIsTupleParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsTuple, methodIsTupleParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsTupleParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsTuple) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_IsTuple_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTuple);
            var currentMethodInfo = this.GetMethodInfo(MethodIsTuple, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsTuple) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_IsTuple_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsTuple);
            var currentMethodInfo = this.GetMethodInfo(MethodIsTuple, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePair) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateKeyValuePair_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateKeyValuePairParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateKeyValuePair, methodGenerateKeyValuePairParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePair) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateKeyValuePair_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePair);
            var keyValuePairType = this.CreateType<Type>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateKeyValuePairParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateKeyValuePair = { keyValuePairType, createdObjectReferences };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateKeyValuePair, methodGenerateKeyValuePairParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateKeyValuePair, methodGenerateKeyValuePairParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateKeyValuePair, parametersOfGenerateKeyValuePair, methodGenerateKeyValuePairParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfGenerateKeyValuePair);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateKeyValuePair.ShouldNotBeNull();
            parametersOfGenerateKeyValuePair.Length.ShouldBe(2);
            methodGenerateKeyValuePairParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePair) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateKeyValuePair_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePair);
            var keyValuePairType = this.CreateType<Type>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateKeyValuePairParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateKeyValuePair = { keyValuePairType, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateKeyValuePair, parametersOfGenerateKeyValuePair, methodGenerateKeyValuePairParametersTypes);

            // Assert
            parametersOfGenerateKeyValuePair.ShouldNotBeNull();
            parametersOfGenerateKeyValuePair.Length.ShouldBe(2);
            methodGenerateKeyValuePairParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePair) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateKeyValuePair_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePair);
            var methodGenerateKeyValuePairParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateKeyValuePair, methodGenerateKeyValuePairParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateKeyValuePairParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePair) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateKeyValuePair_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePair);
            var methodGenerateKeyValuePairParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateKeyValuePair, methodGenerateKeyValuePairParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateKeyValuePairParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateKeyValuePair) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateKeyValuePair_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePair);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateKeyValuePair, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateKeyValuePair) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateKeyValuePair_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateKeyValuePair);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateKeyValuePair, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateArray) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateArray_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateArrayParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateArray, methodGenerateArrayParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateArray) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateArray_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateArray);
            var arrayType = this.CreateType<Type>();
            var size = this.CreateType<int>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateArrayParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateArray = { arrayType, size, createdObjectReferences };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateArray, methodGenerateArrayParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateArray, methodGenerateArrayParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateArray, parametersOfGenerateArray, methodGenerateArrayParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfGenerateArray);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateArray.ShouldNotBeNull();
            parametersOfGenerateArray.Length.ShouldBe(3);
            methodGenerateArrayParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateArray) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateArray_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateArray);
            var arrayType = this.CreateType<Type>();
            var size = this.CreateType<int>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateArrayParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateArray = { arrayType, size, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateArray, parametersOfGenerateArray, methodGenerateArrayParametersTypes);

            // Assert
            parametersOfGenerateArray.ShouldNotBeNull();
            parametersOfGenerateArray.Length.ShouldBe(3);
            methodGenerateArrayParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateArray) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateArray_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateArray);
            var methodGenerateArrayParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateArray, methodGenerateArrayParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateArrayParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GenerateArray) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateArray_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateArray);
            var methodGenerateArrayParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateArray, methodGenerateArrayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateArrayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateArray) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateArray_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateArray);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateArray, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateArray) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateArray_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateArray);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateArray, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateDictionary) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateDictionary_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateDictionaryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateDictionary, methodGenerateDictionaryParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateDictionary) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateDictionary_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionary);
            var dictionaryType = this.CreateType<Type>();
            var size = this.CreateType<int>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateDictionaryParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateDictionary = { dictionaryType, size, createdObjectReferences };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateDictionary, methodGenerateDictionaryParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateDictionary, methodGenerateDictionaryParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateDictionary, parametersOfGenerateDictionary, methodGenerateDictionaryParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfGenerateDictionary);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateDictionary.ShouldNotBeNull();
            parametersOfGenerateDictionary.Length.ShouldBe(3);
            methodGenerateDictionaryParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateDictionary) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateDictionary_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionary);
            var dictionaryType = this.CreateType<Type>();
            var size = this.CreateType<int>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateDictionaryParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateDictionary = { dictionaryType, size, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateDictionary, parametersOfGenerateDictionary, methodGenerateDictionaryParametersTypes);

            // Assert
            parametersOfGenerateDictionary.ShouldNotBeNull();
            parametersOfGenerateDictionary.Length.ShouldBe(3);
            methodGenerateDictionaryParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateDictionary) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateDictionary_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionary);
            var methodGenerateDictionaryParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateDictionary, methodGenerateDictionaryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateDictionaryParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GenerateDictionary) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateDictionary_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionary);
            var methodGenerateDictionaryParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateDictionary, methodGenerateDictionaryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateDictionaryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateDictionary) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateDictionary_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionary);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateDictionary, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateDictionary) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateDictionary_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateDictionary);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateDictionary, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateEnum) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateEnum_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateEnumParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateEnum, methodGenerateEnumParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateEnum) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateEnum_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnum);
            var enumType = this.CreateType<Type>();
            var methodGenerateEnumParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateEnum = { enumType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateEnum, methodGenerateEnumParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateEnum, methodGenerateEnumParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateEnum, parametersOfGenerateEnum, methodGenerateEnumParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfGenerateEnum);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateEnum.ShouldNotBeNull();
            parametersOfGenerateEnum.Length.ShouldBe(1);
            methodGenerateEnumParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateEnum) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateEnum_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnum);
            var enumType = this.CreateType<Type>();
            var methodGenerateEnumParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGenerateEnum = { enumType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateEnum, parametersOfGenerateEnum, methodGenerateEnumParametersTypes);

            // Assert
            parametersOfGenerateEnum.ShouldNotBeNull();
            parametersOfGenerateEnum.Length.ShouldBe(1);
            methodGenerateEnumParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateEnum) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateEnum_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnum);
            var methodGenerateEnumParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateEnum, methodGenerateEnumParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateEnumParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateEnum) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateEnum_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnum);
            var methodGenerateEnumParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateEnum, methodGenerateEnumParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateEnumParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateEnum) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateEnum_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnum);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateEnum, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateEnum) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateEnum_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateEnum);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateEnum, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateQueryable) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateQueryable_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateQueryableParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateQueryable, methodGenerateQueryableParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateQueryable) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateQueryable_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateQueryable);
            var queryableType = this.CreateType<Type>();
            var size = this.CreateType<int>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateQueryableParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateQueryable = { queryableType, size, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateQueryable, parametersOfGenerateQueryable, methodGenerateQueryableParametersTypes);

            // Assert
            parametersOfGenerateQueryable.ShouldNotBeNull();
            parametersOfGenerateQueryable.Length.ShouldBe(3);
            methodGenerateQueryableParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateQueryable) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateQueryable_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateQueryable);
            var methodGenerateQueryableParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateQueryable, methodGenerateQueryableParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGenerateQueryableParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GenerateQueryable) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateQueryable_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateQueryable);
            var methodGenerateQueryableParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateQueryable, methodGenerateQueryableParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateQueryableParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateQueryable) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateQueryable_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateQueryable);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateQueryable, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GenerateQueryable) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateQueryable_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateQueryable);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateQueryable, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateCollection) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateCollection_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateCollection, methodGenerateCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateCollection) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateCollection_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollection);
            var collectionType = this.CreateType<Type>();
            var size = this.CreateType<int>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateCollectionParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateCollection = { collectionType, size, createdObjectReferences };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateCollection, methodGenerateCollectionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateCollection, methodGenerateCollectionParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateCollection, parametersOfGenerateCollection, methodGenerateCollectionParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfGenerateCollection);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateCollection.ShouldNotBeNull();
            parametersOfGenerateCollection.Length.ShouldBe(3);
            methodGenerateCollectionParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateCollection) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateCollection_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollection);
            var collectionType = this.CreateType<Type>();
            var size = this.CreateType<int>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateCollectionParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateCollection = { collectionType, size, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateCollection, parametersOfGenerateCollection, methodGenerateCollectionParametersTypes);

            // Assert
            parametersOfGenerateCollection.ShouldNotBeNull();
            parametersOfGenerateCollection.Length.ShouldBe(3);
            methodGenerateCollectionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateCollection) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateCollection_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollection);
            var methodGenerateCollectionParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateCollection, methodGenerateCollectionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateCollectionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GenerateCollection) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateCollection_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollection);
            var methodGenerateCollectionParametersTypes = new Type[] { typeof(Type), typeof(int), typeof(Dictionary<Type, object>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateCollection, methodGenerateCollectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateCollectionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateCollection) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateCollection_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateCollection, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateCollection) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateCollection_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateCollection, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateNullable) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateNullable_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateNullableParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateNullable, methodGenerateNullableParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateNullable) (Return Type : object) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateNullable_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateNullable);
            var nullableType = this.CreateType<Type>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateNullableParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateNullable = { nullableType, createdObjectReferences };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateNullable, methodGenerateNullableParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateNullable, methodGenerateNullableParametersTypes);
            var result2 = this.GetResultOfMethod<object>(MethodGenerateNullable, parametersOfGenerateNullable, methodGenerateNullableParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfGenerateNullable);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateNullable.ShouldNotBeNull();
            parametersOfGenerateNullable.Length.ShouldBe(2);
            methodGenerateNullableParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateNullable) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateNullable_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateNullable);
            var nullableType = this.CreateType<Type>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateNullableParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateNullable = { nullableType, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateNullable, parametersOfGenerateNullable, methodGenerateNullableParametersTypes);

            // Assert
            parametersOfGenerateNullable.ShouldNotBeNull();
            parametersOfGenerateNullable.Length.ShouldBe(2);
            methodGenerateNullableParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateNullable) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateNullable_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateNullable);
            var methodGenerateNullableParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateNullable, methodGenerateNullableParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateNullableParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateNullable) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateNullable_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateNullable);
            var methodGenerateNullableParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateNullable, methodGenerateNullableParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateNullableParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateNullable) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateNullable_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateNullable);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateNullable, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateNullable) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateNullable_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateNullable);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateNullable, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateComplexObject) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_GenerateComplexObject_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateComplexObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateComplexObject, methodGenerateComplexObjectParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateComplexObject) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateComplexObject_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexObject);
            var type = this.CreateType<Type>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodGenerateComplexObjectParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            object[] parametersOfGenerateComplexObject = { type, createdObjectReferences };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGenerateComplexObject, parametersOfGenerateComplexObject, methodGenerateComplexObjectParametersTypes);

            // Assert
            parametersOfGenerateComplexObject.ShouldNotBeNull();
            parametersOfGenerateComplexObject.Length.ShouldBe(2);
            methodGenerateComplexObjectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateComplexObject) (Return Type : object) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateComplexObject_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexObject);
            var methodGenerateComplexObjectParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateComplexObject, methodGenerateComplexObjectParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGenerateComplexObjectParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateComplexObject) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateComplexObject_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexObject);
            var methodGenerateComplexObjectParametersTypes = new Type[] { typeof(Type), typeof(Dictionary<Type, object>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateComplexObject, methodGenerateComplexObjectParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateComplexObjectParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateComplexObject) (Return Type : object) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateComplexObject_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateComplexObject, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GenerateComplexObject) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_GenerateComplexObject_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateComplexObject);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateComplexObject, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPublicProperties) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_SetPublicProperties_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetPublicPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetPublicProperties, methodSetPublicPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (SetPublicProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicProperties_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicProperties);
            var type = this.CreateType<Type>();
            var obj = this.CreateType<object>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodSetPublicPropertiesParametersTypes = new Type[] { typeof(Type), typeof(object), typeof(Dictionary<Type, object>) };
            object[] parametersOfSetPublicProperties = { type, obj, createdObjectReferences };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPublicProperties, methodSetPublicPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfSetPublicProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetPublicProperties.ShouldNotBeNull();
            parametersOfSetPublicProperties.Length.ShouldBe(3);
            methodSetPublicPropertiesParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetPublicProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicProperties_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicProperties);
            var type = this.CreateType<Type>();
            var obj = this.CreateType<object>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodSetPublicPropertiesParametersTypes = new Type[] { typeof(Type), typeof(object), typeof(Dictionary<Type, object>) };
            object[] parametersOfSetPublicProperties = { type, obj, createdObjectReferences };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetPublicProperties, parametersOfSetPublicProperties, methodSetPublicPropertiesParametersTypes);

            // Assert
            parametersOfSetPublicProperties.ShouldNotBeNull();
            parametersOfSetPublicProperties.Length.ShouldBe(3);
            methodSetPublicPropertiesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPublicProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicProperties_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPublicProperties, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPublicProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicProperties_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicProperties);
            var methodSetPublicPropertiesParametersTypes = new Type[] { typeof(Type), typeof(object), typeof(Dictionary<Type, object>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetPublicProperties, methodSetPublicPropertiesParametersTypes);

            // Assert
            methodSetPublicPropertiesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPublicProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicProperties_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPublicProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPublicFields) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ObjectGenerator_SetPublicFields_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetPublicFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetPublicFields, methodSetPublicFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (SetPublicFields) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicFields_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicFields);
            var type = this.CreateType<Type>();
            var obj = this.CreateType<object>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodSetPublicFieldsParametersTypes = new Type[] { typeof(Type), typeof(object), typeof(Dictionary<Type, object>) };
            object[] parametersOfSetPublicFields = { type, obj, createdObjectReferences };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPublicFields, methodSetPublicFieldsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_objectGeneratorInstanceFixture, parametersOfSetPublicFields);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetPublicFields.ShouldNotBeNull();
            parametersOfSetPublicFields.Length.ShouldBe(3);
            methodSetPublicFieldsParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetPublicFields) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicFields_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicFields);
            var type = this.CreateType<Type>();
            var obj = this.CreateType<object>();
            var createdObjectReferences = this.CreateType<dynamic>();
            var methodSetPublicFieldsParametersTypes = new Type[] { typeof(Type), typeof(object), typeof(Dictionary<Type, object>) };
            object[] parametersOfSetPublicFields = { type, obj, createdObjectReferences };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetPublicFields, parametersOfSetPublicFields, methodSetPublicFieldsParametersTypes);

            // Assert
            parametersOfSetPublicFields.ShouldNotBeNull();
            parametersOfSetPublicFields.Length.ShouldBe(3);
            methodSetPublicFieldsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPublicFields) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicFields_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicFields);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPublicFields, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPublicFields) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicFields_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicFields);
            var methodSetPublicFieldsParametersTypes = new Type[] { typeof(Type), typeof(object), typeof(Dictionary<Type, object>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetPublicFields, methodSetPublicFieldsParametersTypes);

            // Assert
            methodSetPublicFieldsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPublicFields) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ObjectGenerator_SetPublicFields_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPublicFields);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPublicFields, 0);

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