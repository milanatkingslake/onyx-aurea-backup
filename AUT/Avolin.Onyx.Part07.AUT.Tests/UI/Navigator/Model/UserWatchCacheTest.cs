using System;
using System.Collections.Generic;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.UserWatchCache" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UserWatchCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UserWatchCache" />)
        /// </summary>
        public UserWatchCacheTest() : base(typeof(UserWatchCache))
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

        #region General Initializer : Class (UserWatchCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _userWatchCacheInstanceType;
        private UserWatchCache _userWatchCacheInstance;
        private UserWatchCache _userWatchCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UserWatchCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userWatchCacheInstanceType = typeof(UserWatchCache);
            _userWatchCacheInstanceFixture = this.Create<UserWatchCache>(false);
            _userWatchCacheInstance = _userWatchCacheInstanceFixture ?? this.Create<UserWatchCache>(true);
            CurrentInstance = _userWatchCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserWatchCache) Initializer

        #region Properties

        private const string PropertyUserWatchCacheInstance = "UserWatchCacheInstance";

        #endregion

        #region Methods

        private const string MethodUpdateWatchCacheDictionary = "UpdateWatchCacheDictionary";
        private const string MethodRemoveWatchCacheDictionary = "RemoveWatchCacheDictionary";
        private const string MethodUpdateWatchCacheDictionaryItem = "UpdateWatchCacheDictionaryItem";
        private const string MethodUpdateWatchCallList = "UpdateWatchCallList";
        private const string MethodIsRecordDisabled = "IsRecordDisabled";
        private const string MethodIsRecordWatched = "IsRecordWatched";
        private const string MethodIsCacheAvailable = "IsCacheAvailable";

        #endregion

        #region Fields

        private const string FieldsyncRoot = "syncRoot";
        private const string FielduserWatchCacheDictionary = "userWatchCacheDictionary";
        private const string FielduserWatchCallList = "userWatchCallList";
        private const string FielduserWatchCacheInstance = "userWatchCacheInstance";

        #endregion

        #endregion

        #region General Initializer : Class (UserWatchCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserWatchCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserWatchCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserWatchCache) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UserWatchCache" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserWatchCache_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserWatchCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserWatchCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserWatchCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UserWatchCache)

        #region General Initializer : Class (UserWatchCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="UserWatchCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodUpdateWatchCacheDictionary, 0)]
        [TestCase(MethodRemoveWatchCacheDictionary, 0)]
        [TestCase(MethodUpdateWatchCacheDictionaryItem, 0)]
        [TestCase(MethodUpdateWatchCallList, 0)]
        [TestCase(MethodIsRecordDisabled, 0)]
        [TestCase(MethodIsRecordWatched, 0)]
        [TestCase(MethodIsCacheAvailable, 0)]
        public void AUT_UserWatchCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (UserWatchCache) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="UserWatchCache" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUserWatchCacheInstance)]
        [Category("AUT Property")]
        public void AUT_UserWatchCache_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (UserWatchCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="UserWatchCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldsyncRoot)]
        [TestCase(FielduserWatchCacheDictionary)]
        [TestCase(FielduserWatchCallList)]
        [TestCase(FielduserWatchCacheInstance)]
        [Category("AUT Fields")]
        public void AUT_UserWatchCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UserWatchCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UserWatchCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserWatchCache_Is_Instance_Present_Test()
        {
            // Assert
            _userWatchCacheInstanceType.ShouldNotBeNull();
            _userWatchCacheInstance.ShouldNotBeNull();
            _userWatchCacheInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UserWatchCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UserWatchCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserWatchCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _userWatchCacheInstance.ShouldBeAssignableTo<UserWatchCache>();
            _userWatchCacheInstanceFixture.ShouldBeAssignableTo<UserWatchCache>();
            CurrentInstance.ShouldBeAssignableTo<UserWatchCache>();
        }

        #endregion

        #endregion
        
        #region Category : GetterSetter

        #region General Getters/Setters : Class (UserWatchCache) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUserWatchCacheInstance)]
        public void AUT_UserWatchCache_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (UserWatchCache) => Property (UserWatchCacheInstance) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserWatchCache_UserWatchCacheInstance_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserWatchCacheInstance);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUserWatchCacheInstance);
            Action currentAction = () => propertyInfo.SetValue(_userWatchCacheInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (UserWatchCache) => Property (UserWatchCacheInstance) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserWatchCache_Public_Class_UserWatchCacheInstance_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserWatchCacheInstance);
            var propertyInfo = this.GetPropertyInfo(PropertyUserWatchCacheInstance);

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

        #region Method Call : (UpdateWatchCacheDictionary) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionary_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionary);
            var key = this.CreateType<string>();
            var value = this.CreateType<List<String>>();

            // Act
            Action executeAction = () => _userWatchCacheInstance.UpdateWatchCacheDictionary(key, value);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionary) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionary_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionary);
            var key = this.CreateType<string>();
            var value = this.CreateType<List<String>>();
            var methodUpdateWatchCacheDictionaryParametersTypes = new Type[] { typeof(string), typeof(List<String>) };
            object[] parametersOfUpdateWatchCacheDictionary = { key, value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateWatchCacheDictionary, methodUpdateWatchCacheDictionaryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userWatchCacheInstanceFixture, parametersOfUpdateWatchCacheDictionary);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateWatchCacheDictionary.ShouldNotBeNull();
            parametersOfUpdateWatchCacheDictionary.Length.ShouldBe(2);
            methodUpdateWatchCacheDictionaryParametersTypes.Length.ShouldBe(2);
            methodUpdateWatchCacheDictionaryParametersTypes.Length.ShouldBe(parametersOfUpdateWatchCacheDictionary.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionary) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionary_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionary);
            var key = this.CreateType<string>();
            var value = this.CreateType<List<String>>();
            var methodUpdateWatchCacheDictionaryParametersTypes = new Type[] { typeof(string), typeof(List<String>) };
            object[] parametersOfUpdateWatchCacheDictionary = { key, value };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateWatchCacheDictionary, parametersOfUpdateWatchCacheDictionary, methodUpdateWatchCacheDictionaryParametersTypes);

            // Assert
            parametersOfUpdateWatchCacheDictionary.ShouldNotBeNull();
            parametersOfUpdateWatchCacheDictionary.Length.ShouldBe(2);
            methodUpdateWatchCacheDictionaryParametersTypes.Length.ShouldBe(2);
            methodUpdateWatchCacheDictionaryParametersTypes.Length.ShouldBe(parametersOfUpdateWatchCacheDictionary.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionary) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionary_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionary);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateWatchCacheDictionary, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionary) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionary_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionary);
            var methodUpdateWatchCacheDictionaryParametersTypes = new Type[] { typeof(string), typeof(List<String>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateWatchCacheDictionary, methodUpdateWatchCacheDictionaryParametersTypes);

            // Assert
            methodUpdateWatchCacheDictionaryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionary) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionary_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionary);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateWatchCacheDictionary, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveWatchCacheDictionary) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserWatchCache_RemoveWatchCacheDictionary_Method_Call_Internally(Type[] types)
        {
            var methodRemoveWatchCacheDictionaryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveWatchCacheDictionary, methodRemoveWatchCacheDictionaryParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveWatchCacheDictionary) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_RemoveWatchCacheDictionary_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveWatchCacheDictionary);
            var key = this.CreateType<string>();

            // Act
            Action executeAction = () => _userWatchCacheInstance.RemoveWatchCacheDictionary(key);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveWatchCacheDictionary) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_RemoveWatchCacheDictionary_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveWatchCacheDictionary);
            var key = this.CreateType<string>();
            var methodRemoveWatchCacheDictionaryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemoveWatchCacheDictionary = { key };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveWatchCacheDictionary, methodRemoveWatchCacheDictionaryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userWatchCacheInstanceFixture, parametersOfRemoveWatchCacheDictionary);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveWatchCacheDictionary.ShouldNotBeNull();
            parametersOfRemoveWatchCacheDictionary.Length.ShouldBe(1);
            methodRemoveWatchCacheDictionaryParametersTypes.Length.ShouldBe(1);
            methodRemoveWatchCacheDictionaryParametersTypes.Length.ShouldBe(parametersOfRemoveWatchCacheDictionary.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveWatchCacheDictionary) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_RemoveWatchCacheDictionary_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveWatchCacheDictionary);
            var key = this.CreateType<string>();
            var methodRemoveWatchCacheDictionaryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemoveWatchCacheDictionary = { key };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveWatchCacheDictionary, parametersOfRemoveWatchCacheDictionary, methodRemoveWatchCacheDictionaryParametersTypes);

            // Assert
            parametersOfRemoveWatchCacheDictionary.ShouldNotBeNull();
            parametersOfRemoveWatchCacheDictionary.Length.ShouldBe(1);
            methodRemoveWatchCacheDictionaryParametersTypes.Length.ShouldBe(1);
            methodRemoveWatchCacheDictionaryParametersTypes.Length.ShouldBe(parametersOfRemoveWatchCacheDictionary.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveWatchCacheDictionary) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_RemoveWatchCacheDictionary_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveWatchCacheDictionary);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveWatchCacheDictionary, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveWatchCacheDictionary) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_RemoveWatchCacheDictionary_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveWatchCacheDictionary);
            var methodRemoveWatchCacheDictionaryParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveWatchCacheDictionary, methodRemoveWatchCacheDictionaryParametersTypes);

            // Assert
            methodRemoveWatchCacheDictionaryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveWatchCacheDictionary) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_RemoveWatchCacheDictionary_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveWatchCacheDictionary);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveWatchCacheDictionary, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionaryItem) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserWatchCache_UpdateWatchCacheDictionaryItem_Method_Call_Internally(Type[] types)
        {
            var methodUpdateWatchCacheDictionaryItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateWatchCacheDictionaryItem, methodUpdateWatchCacheDictionaryItemParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionaryItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionaryItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionaryItem);
            var key = this.CreateType<string>();
            var primaryid = this.CreateType<string>();

            // Act
            Action executeAction = () => _userWatchCacheInstance.UpdateWatchCacheDictionaryItem(key, primaryid);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionaryItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionaryItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionaryItem);
            var key = this.CreateType<string>();
            var primaryid = this.CreateType<string>();
            var methodUpdateWatchCacheDictionaryItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfUpdateWatchCacheDictionaryItem = { key, primaryid };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateWatchCacheDictionaryItem, methodUpdateWatchCacheDictionaryItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userWatchCacheInstanceFixture, parametersOfUpdateWatchCacheDictionaryItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateWatchCacheDictionaryItem.ShouldNotBeNull();
            parametersOfUpdateWatchCacheDictionaryItem.Length.ShouldBe(2);
            methodUpdateWatchCacheDictionaryItemParametersTypes.Length.ShouldBe(2);
            methodUpdateWatchCacheDictionaryItemParametersTypes.Length.ShouldBe(parametersOfUpdateWatchCacheDictionaryItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionaryItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionaryItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionaryItem);
            var key = this.CreateType<string>();
            var primaryid = this.CreateType<string>();
            var methodUpdateWatchCacheDictionaryItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfUpdateWatchCacheDictionaryItem = { key, primaryid };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateWatchCacheDictionaryItem, parametersOfUpdateWatchCacheDictionaryItem, methodUpdateWatchCacheDictionaryItemParametersTypes);

            // Assert
            parametersOfUpdateWatchCacheDictionaryItem.ShouldNotBeNull();
            parametersOfUpdateWatchCacheDictionaryItem.Length.ShouldBe(2);
            methodUpdateWatchCacheDictionaryItemParametersTypes.Length.ShouldBe(2);
            methodUpdateWatchCacheDictionaryItemParametersTypes.Length.ShouldBe(parametersOfUpdateWatchCacheDictionaryItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionaryItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionaryItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionaryItem);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateWatchCacheDictionaryItem, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionaryItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionaryItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionaryItem);
            var methodUpdateWatchCacheDictionaryItemParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateWatchCacheDictionaryItem, methodUpdateWatchCacheDictionaryItemParametersTypes);

            // Assert
            methodUpdateWatchCacheDictionaryItemParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCacheDictionaryItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCacheDictionaryItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCacheDictionaryItem);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateWatchCacheDictionaryItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCallList) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserWatchCache_UpdateWatchCallList_Method_Call_Internally(Type[] types)
        {
            var methodUpdateWatchCallListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateWatchCallList, methodUpdateWatchCallListParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateWatchCallList) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCallList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCallList);
            var primaryid = this.CreateType<string>();

            // Act
            Action executeAction = () => _userWatchCacheInstance.UpdateWatchCallList(primaryid);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCallList) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCallList_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCallList);
            var primaryid = this.CreateType<string>();
            var methodUpdateWatchCallListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfUpdateWatchCallList = { primaryid };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateWatchCallList, methodUpdateWatchCallListParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userWatchCacheInstanceFixture, parametersOfUpdateWatchCallList);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateWatchCallList.ShouldNotBeNull();
            parametersOfUpdateWatchCallList.Length.ShouldBe(1);
            methodUpdateWatchCallListParametersTypes.Length.ShouldBe(1);
            methodUpdateWatchCallListParametersTypes.Length.ShouldBe(parametersOfUpdateWatchCallList.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCallList) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCallList_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCallList);
            var primaryid = this.CreateType<string>();
            var methodUpdateWatchCallListParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfUpdateWatchCallList = { primaryid };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateWatchCallList, parametersOfUpdateWatchCallList, methodUpdateWatchCallListParametersTypes);

            // Assert
            parametersOfUpdateWatchCallList.ShouldNotBeNull();
            parametersOfUpdateWatchCallList.Length.ShouldBe(1);
            methodUpdateWatchCallListParametersTypes.Length.ShouldBe(1);
            methodUpdateWatchCallListParametersTypes.Length.ShouldBe(parametersOfUpdateWatchCallList.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCallList) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCallList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCallList);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateWatchCallList, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateWatchCallList) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCallList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCallList);
            var methodUpdateWatchCallListParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateWatchCallList, methodUpdateWatchCallListParametersTypes);

            // Assert
            methodUpdateWatchCallListParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateWatchCallList) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_UpdateWatchCallList_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateWatchCallList);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateWatchCallList, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsRecordDisabled) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserWatchCache_IsRecordDisabled_Method_Call_Internally(Type[] types)
        {
            var methodIsRecordDisabledParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsRecordDisabled, methodIsRecordDisabledParametersTypes);
        }

        #endregion

        #region Method Call : (IsRecordDisabled) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordDisabled_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordDisabled);
            var primaryid = this.CreateType<string>();

            // Act
            Action executeAction = () => _userWatchCacheInstance.IsRecordDisabled(primaryid);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (IsRecordDisabled) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordDisabled_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordDisabled);
            var primaryid = this.CreateType<string>();
            var methodIsRecordDisabledParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsRecordDisabled = { primaryid };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsRecordDisabled, methodIsRecordDisabledParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_userWatchCacheInstanceFixture, parametersOfIsRecordDisabled);
            var result2 = this.GetResultOfMethod<bool>(MethodIsRecordDisabled, parametersOfIsRecordDisabled, methodIsRecordDisabledParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsRecordDisabled.ShouldNotBeNull();
            parametersOfIsRecordDisabled.Length.ShouldBe(1);
            methodIsRecordDisabledParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsRecordDisabled) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordDisabled_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordDisabled);
            var primaryid = this.CreateType<string>();
            var methodIsRecordDisabledParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsRecordDisabled = { primaryid };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsRecordDisabled, methodIsRecordDisabledParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_userWatchCacheInstanceFixture, out exception1, parametersOfIsRecordDisabled);
            var result2 = this.GetResultOfMethod<bool>(MethodIsRecordDisabled, parametersOfIsRecordDisabled, methodIsRecordDisabledParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsRecordDisabled.ShouldNotBeNull();
            parametersOfIsRecordDisabled.Length.ShouldBe(1);
            methodIsRecordDisabledParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsRecordDisabled) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordDisabled_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordDisabled);
            var primaryid = this.CreateType<string>();
            var methodIsRecordDisabledParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsRecordDisabled = { primaryid };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsRecordDisabled, parametersOfIsRecordDisabled, methodIsRecordDisabledParametersTypes);

            // Assert
            parametersOfIsRecordDisabled.ShouldNotBeNull();
            parametersOfIsRecordDisabled.Length.ShouldBe(1);
            methodIsRecordDisabledParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsRecordDisabled) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordDisabled_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordDisabled);
            var methodIsRecordDisabledParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsRecordDisabled, methodIsRecordDisabledParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsRecordDisabledParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsRecordDisabled) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordDisabled_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordDisabled);
            var currentMethodInfo = this.GetMethodInfo(MethodIsRecordDisabled, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsRecordDisabled) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordDisabled_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordDisabled);
            var currentMethodInfo = this.GetMethodInfo(MethodIsRecordDisabled, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsRecordWatched) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserWatchCache_IsRecordWatched_Method_Call_Internally(Type[] types)
        {
            var methodIsRecordWatchedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsRecordWatched, methodIsRecordWatchedParametersTypes);
        }

        #endregion

        #region Method Call : (IsRecordWatched) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordWatched_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordWatched);
            var key = this.CreateType<string>();
            var primaryid = this.CreateType<string>();

            // Act
            Action executeAction = () => _userWatchCacheInstance.IsRecordWatched(key, primaryid);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (IsRecordWatched) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordWatched_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordWatched);
            var key = this.CreateType<string>();
            var primaryid = this.CreateType<string>();
            var methodIsRecordWatchedParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfIsRecordWatched = { key, primaryid };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsRecordWatched, methodIsRecordWatchedParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_userWatchCacheInstanceFixture, parametersOfIsRecordWatched);
            var result2 = this.GetResultOfMethod<bool>(MethodIsRecordWatched, parametersOfIsRecordWatched, methodIsRecordWatchedParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsRecordWatched.ShouldNotBeNull();
            parametersOfIsRecordWatched.Length.ShouldBe(2);
            methodIsRecordWatchedParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsRecordWatched) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordWatched_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordWatched);
            var key = this.CreateType<string>();
            var primaryid = this.CreateType<string>();
            var methodIsRecordWatchedParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfIsRecordWatched = { key, primaryid };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsRecordWatched, methodIsRecordWatchedParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_userWatchCacheInstanceFixture, out exception1, parametersOfIsRecordWatched);
            var result2 = this.GetResultOfMethod<bool>(MethodIsRecordWatched, parametersOfIsRecordWatched, methodIsRecordWatchedParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsRecordWatched.ShouldNotBeNull();
            parametersOfIsRecordWatched.Length.ShouldBe(2);
            methodIsRecordWatchedParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsRecordWatched) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordWatched_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordWatched);
            var key = this.CreateType<string>();
            var primaryid = this.CreateType<string>();
            var methodIsRecordWatchedParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfIsRecordWatched = { key, primaryid };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsRecordWatched, parametersOfIsRecordWatched, methodIsRecordWatchedParametersTypes);

            // Assert
            parametersOfIsRecordWatched.ShouldNotBeNull();
            parametersOfIsRecordWatched.Length.ShouldBe(2);
            methodIsRecordWatchedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsRecordWatched) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordWatched_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordWatched);
            var methodIsRecordWatchedParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsRecordWatched, methodIsRecordWatchedParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsRecordWatchedParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsRecordWatched) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordWatched_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordWatched);
            var currentMethodInfo = this.GetMethodInfo(MethodIsRecordWatched, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsRecordWatched) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsRecordWatched_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsRecordWatched);
            var currentMethodInfo = this.GetMethodInfo(MethodIsRecordWatched, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsCacheAvailable) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserWatchCache_IsCacheAvailable_Method_Call_Internally(Type[] types)
        {
            var methodIsCacheAvailableParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsCacheAvailable, methodIsCacheAvailableParametersTypes);
        }

        #endregion

        #region Method Call : (IsCacheAvailable) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsCacheAvailable_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCacheAvailable);
            var key = this.CreateType<string>();

            // Act
            Action executeAction = () => _userWatchCacheInstance.IsCacheAvailable(key);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (IsCacheAvailable) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsCacheAvailable_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCacheAvailable);
            var key = this.CreateType<string>();
            var methodIsCacheAvailableParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsCacheAvailable = { key };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsCacheAvailable, methodIsCacheAvailableParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_userWatchCacheInstanceFixture, parametersOfIsCacheAvailable);
            var result2 = this.GetResultOfMethod<bool>(MethodIsCacheAvailable, parametersOfIsCacheAvailable, methodIsCacheAvailableParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsCacheAvailable.ShouldNotBeNull();
            parametersOfIsCacheAvailable.Length.ShouldBe(1);
            methodIsCacheAvailableParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsCacheAvailable) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsCacheAvailable_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCacheAvailable);
            var key = this.CreateType<string>();
            var methodIsCacheAvailableParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsCacheAvailable = { key };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsCacheAvailable, methodIsCacheAvailableParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_userWatchCacheInstanceFixture, out exception1, parametersOfIsCacheAvailable);
            var result2 = this.GetResultOfMethod<bool>(MethodIsCacheAvailable, parametersOfIsCacheAvailable, methodIsCacheAvailableParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsCacheAvailable.ShouldNotBeNull();
            parametersOfIsCacheAvailable.Length.ShouldBe(1);
            methodIsCacheAvailableParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsCacheAvailable) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsCacheAvailable_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCacheAvailable);
            var key = this.CreateType<string>();
            var methodIsCacheAvailableParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfIsCacheAvailable = { key };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsCacheAvailable, parametersOfIsCacheAvailable, methodIsCacheAvailableParametersTypes);

            // Assert
            parametersOfIsCacheAvailable.ShouldNotBeNull();
            parametersOfIsCacheAvailable.Length.ShouldBe(1);
            methodIsCacheAvailableParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsCacheAvailable) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsCacheAvailable_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCacheAvailable);
            var methodIsCacheAvailableParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsCacheAvailable, methodIsCacheAvailableParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsCacheAvailableParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsCacheAvailable) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsCacheAvailable_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCacheAvailable);
            var currentMethodInfo = this.GetMethodInfo(MethodIsCacheAvailable, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsCacheAvailable) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserWatchCache_IsCacheAvailable_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsCacheAvailable);
            var currentMethodInfo = this.GetMethodInfo(MethodIsCacheAvailable, 0);
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