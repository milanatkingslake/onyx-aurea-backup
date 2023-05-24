using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxUserGroupCache" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxUserGroupCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxUserGroupCache" />)
        /// </summary>
        public OnyxUserGroupCacheTest() : base(typeof(OnyxUserGroupCache))
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

        #region General Initializer : Class (OnyxUserGroupCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxUserGroupCacheInstanceType;
        private OnyxUserGroupCache _onyxUserGroupCacheInstance;
        private OnyxUserGroupCache _onyxUserGroupCacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxUserGroupCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxUserGroupCacheInstanceType = typeof(OnyxUserGroupCache);
            _onyxUserGroupCacheInstanceFixture = this.Create<OnyxUserGroupCache>(false);
            _onyxUserGroupCacheInstance = _onyxUserGroupCacheInstanceFixture ?? this.Create<OnyxUserGroupCache>(true);
            CurrentInstance = _onyxUserGroupCacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxUserGroupCache) Initializer

        #region Methods

        private const string MethodretrieveFromOnyx = "retrieveFromOnyx";
        private const string MethodGetGroupName = "GetGroupName";

        #endregion

        #region Fields

        private const string FielduserGroupsDict = "userGroupsDict";
        private const string FieldloadLock = "loadLock";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxUserGroupCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxUserGroupCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserGroupCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxUserGroupCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxUserGroupCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxUserGroupCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxUserGroupCache)

        #region General Initializer : Class (OnyxUserGroupCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxUserGroupCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodretrieveFromOnyx, 0)]
        [TestCase(MethodGetGroupName, 0)]
        public void AUT_OnyxUserGroupCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxUserGroupCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxUserGroupCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FielduserGroupsDict)]
        [TestCase(FieldloadLock)]
        [Category("AUT Fields")]
        public void AUT_OnyxUserGroupCache_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxUserGroupCache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxUserGroupCache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxUserGroupCache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxUserGroupCacheInstance.ShouldBeAssignableTo<OnyxUserGroupCache>();
            _onyxUserGroupCacheInstanceFixture.ShouldBeAssignableTo<OnyxUserGroupCache>();
            CurrentInstance.ShouldBeAssignableTo<OnyxUserGroupCache>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_retrieveFromOnyx_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;
            object[] parametersOfretrieveFromOnyx = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxUserGroupCacheInstanceFixture, parametersOfretrieveFromOnyx);
            var result2 = this.GetResultOfMethod<String>(MethodretrieveFromOnyx, parametersOfretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfretrieveFromOnyx.ShouldBeNull();
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_retrieveFromOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;
            object[] parametersOfretrieveFromOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodretrieveFromOnyx, parametersOfretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            parametersOfretrieveFromOnyx.ShouldBeNull();
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            Type [] methodretrieveFromOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodretrieveFromOnyx, methodretrieveFromOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodretrieveFromOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveFromOnyx) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_retrieveFromOnyx_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveFromOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveFromOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGroupName) (Return Type : String) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxUserGroupCache_GetGroupName_Method_Call_Internally(Type[] types)
        {
            var methodGetGroupNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetGroupName, methodGetGroupNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetGroupName) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_GetGroupName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroupName);
            var groupId = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxUserGroupCacheInstance.GetGroupName(groupId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetGroupName) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_GetGroupName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroupName);
            var groupId = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxUserGroupCacheInstance.GetGroupName(groupId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGroupName) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_GetGroupName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroupName);
            var groupId = this.CreateType<string>();
            var methodGetGroupNameParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetGroupName = { groupId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGroupName, methodGetGroupNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxUserGroupCacheInstanceFixture, parametersOfGetGroupName);
            var result2 = this.GetResultOfMethod<String>(MethodGetGroupName, parametersOfGetGroupName, methodGetGroupNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetGroupName.ShouldNotBeNull();
            parametersOfGetGroupName.Length.ShouldBe(1);
            methodGetGroupNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetGroupName) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_GetGroupName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroupName);
            var groupId = this.CreateType<string>();
            var methodGetGroupNameParametersTypes = new Type[] { typeof(String) };
            object[] parametersOfGetGroupName = { groupId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetGroupName, parametersOfGetGroupName, methodGetGroupNameParametersTypes);

            // Assert
            parametersOfGetGroupName.ShouldNotBeNull();
            parametersOfGetGroupName.Length.ShouldBe(1);
            methodGetGroupNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGroupName) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_GetGroupName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroupName);
            var methodGetGroupNameParametersTypes = new Type[] { typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetGroupName, methodGetGroupNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetGroupNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetGroupName) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_GetGroupName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroupName);
            var methodGetGroupNameParametersTypes = new Type[] { typeof(String) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGroupName, methodGetGroupNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetGroupNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetGroupName) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_GetGroupName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroupName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGroupName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGroupName) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxUserGroupCache_GetGroupName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGroupName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGroupName, 0);
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