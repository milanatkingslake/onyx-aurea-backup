using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ReportingService2005" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ReportingService20050Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20050Test() : base(typeof(ReportingService2005))
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

        #region General Initializer : Class (ReportingService2005) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private ReportingService2005 _reportingService2005Instance;
        private ReportingService2005 _reportingService2005InstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReportingService2005" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _reportingService2005InstanceFixture = this.Create<ReportingService2005>(false);
            _reportingService2005Instance = _reportingService2005InstanceFixture ?? this.Create<ReportingService2005>(true);
            CurrentInstance = _reportingService2005Instance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReportingService2005) Initializer
        
        #region Methods

        private const string MethodListTasks = "ListTasks";
        private const string MethodOnListTasksOperationCompleted = "OnListTasksOperationCompleted";
        private const string MethodListRoles = "ListRoles";
        private const string MethodOnListRolesOperationCompleted = "OnListRolesOperationCompleted";
        private const string MethodCreateRole = "CreateRole";
        private const string MethodOnCreateRoleOperationCompleted = "OnCreateRoleOperationCompleted";
        private const string MethodDeleteRole = "DeleteRole";
        private const string MethodOnDeleteRoleOperationCompleted = "OnDeleteRoleOperationCompleted";
        private const string MethodGetRoleProperties = "GetRoleProperties";
        private const string MethodOnGetRolePropertiesOperationCompleted = "OnGetRolePropertiesOperationCompleted";
        private const string MethodSetRoleProperties = "SetRoleProperties";
        private const string MethodOnSetRolePropertiesOperationCompleted = "OnSetRolePropertiesOperationCompleted";
        private const string MethodGetSystemPolicies = "GetSystemPolicies";
        private const string MethodOnGetSystemPoliciesOperationCompleted = "OnGetSystemPoliciesOperationCompleted";
        private const string MethodSetSystemPolicies = "SetSystemPolicies";
        private const string MethodOnSetSystemPoliciesOperationCompleted = "OnSetSystemPoliciesOperationCompleted";
        private const string MethodGetPolicies = "GetPolicies";
        private const string MethodOnGetPoliciesOperationCompleted = "OnGetPoliciesOperationCompleted";
        private const string MethodSetPolicies = "SetPolicies";
        private const string MethodOnSetPoliciesOperationCompleted = "OnSetPoliciesOperationCompleted";
        private const string MethodInheritParentSecurity = "InheritParentSecurity";
        private const string MethodOnInheritParentSecurityOperationCompleted = "OnInheritParentSecurityOperationCompleted";
        private const string MethodGetSystemPermissions = "GetSystemPermissions";
        private const string MethodOnGetSystemPermissionsOperationCompleted = "OnGetSystemPermissionsOperationCompleted";
        private const string MethodGetPermissions = "GetPermissions";
        private const string MethodOnGetPermissionsOperationCompleted = "OnGetPermissionsOperationCompleted";
        private const string MethodLogonUser = "LogonUser";
        private const string MethodOnLogonUserOperationCompleted = "OnLogonUserOperationCompleted";
        
        #endregion
        
        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (ListTasks) (Return Type : Task[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListTasks_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListTasks);
            var SecurityScope = this.CreateType<SecurityScopeEnum>();
            var methodListTasksParametersTypes = new Type[] { typeof(SecurityScopeEnum) };
            object[] parametersOfListTasks = { SecurityScope };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListTasks, methodListTasksParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Task[]>(_reportingService2005InstanceFixture, parametersOfListTasks);
            var result2 = this.GetResultOfMethod<Task[]>(MethodListTasks, parametersOfListTasks, methodListTasksParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListTasks.ShouldNotBeNull();
            parametersOfListTasks.Length.ShouldBe(1);
            methodListTasksParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListTasks) (Return Type : Task[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListTasks_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListTasks);
            var SecurityScope = this.CreateType<SecurityScopeEnum>();
            var methodListTasksParametersTypes = new Type[] { typeof(SecurityScopeEnum) };
            object[] parametersOfListTasks = { SecurityScope };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Task[]>(MethodListTasks, parametersOfListTasks, methodListTasksParametersTypes);

            // Assert
            parametersOfListTasks.ShouldNotBeNull();
            parametersOfListTasks.Length.ShouldBe(1);
            methodListTasksParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListTasks) (Return Type : Task[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListTasks_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListTasks);
            var methodListTasksParametersTypes = new Type[] { typeof(SecurityScopeEnum) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListTasks, methodListTasksParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListTasksParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListTasks) (Return Type : Task[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListTasks_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListTasks);
            var methodListTasksParametersTypes = new Type[] { typeof(SecurityScopeEnum) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListTasks, methodListTasksParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListTasksParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListTasks) (Return Type : Task[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListTasks_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListTasks);
            var currentMethodInfo = this.GetMethodInfo(MethodListTasks, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListTasks) (Return Type : Task[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListTasks_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListTasks);
            var currentMethodInfo = this.GetMethodInfo(MethodListTasks, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListTasksOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListTasksOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListTasksOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListTasksOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListTasksOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListTasksOperationCompleted, parametersOfOnListTasksOperationCompleted, methodOnListTasksOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListTasksOperationCompleted.ShouldNotBeNull();
            parametersOfOnListTasksOperationCompleted.Length.ShouldBe(1);
            methodOnListTasksOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListTasksOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListTasksOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListTasksOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListTasksOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListTasksOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListTasksOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListTasksOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListTasksOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListTasksOperationCompleted);
            var methodOnListTasksOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListTasksOperationCompleted, methodOnListTasksOperationCompletedParametersTypes);

            // Assert
            methodOnListTasksOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListTasksOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListTasksOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListTasksOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListTasksOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListRoles) (Return Type : Role[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListRoles_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListRoles);
            var SecurityScope = this.CreateType<SecurityScopeEnum>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListRoles(SecurityScope);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListRoles) (Return Type : Role[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListRoles_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListRoles);
            var SecurityScope = this.CreateType<SecurityScopeEnum>();
            var returnedValue = default(Role[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListRoles(SecurityScope);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListRoles) (Return Type : Role[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListRoles_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListRoles);
            var SecurityScope = this.CreateType<SecurityScopeEnum>();
            var methodListRolesParametersTypes = new Type[] { typeof(SecurityScopeEnum) };
            object[] parametersOfListRoles = { SecurityScope };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListRoles, methodListRolesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Role[]>(_reportingService2005InstanceFixture, parametersOfListRoles);
            var result2 = this.GetResultOfMethod<Role[]>(MethodListRoles, parametersOfListRoles, methodListRolesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListRoles.ShouldNotBeNull();
            parametersOfListRoles.Length.ShouldBe(1);
            methodListRolesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListRoles) (Return Type : Role[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListRoles_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListRoles);
            var SecurityScope = this.CreateType<SecurityScopeEnum>();
            var methodListRolesParametersTypes = new Type[] { typeof(SecurityScopeEnum) };
            object[] parametersOfListRoles = { SecurityScope };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Role[]>(MethodListRoles, parametersOfListRoles, methodListRolesParametersTypes);

            // Assert
            parametersOfListRoles.ShouldNotBeNull();
            parametersOfListRoles.Length.ShouldBe(1);
            methodListRolesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListRoles) (Return Type : Role[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListRoles_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListRoles);
            var methodListRolesParametersTypes = new Type[] { typeof(SecurityScopeEnum) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListRoles, methodListRolesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListRolesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListRoles) (Return Type : Role[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListRoles_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListRoles);
            var methodListRolesParametersTypes = new Type[] { typeof(SecurityScopeEnum) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListRoles, methodListRolesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListRolesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListRoles) (Return Type : Role[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListRoles_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListRoles);
            var currentMethodInfo = this.GetMethodInfo(MethodListRoles, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListRoles) (Return Type : Role[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListRoles_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListRoles);
            var currentMethodInfo = this.GetMethodInfo(MethodListRoles, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListRolesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListRolesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListRolesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListRolesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListRolesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListRolesOperationCompleted, parametersOfOnListRolesOperationCompleted, methodOnListRolesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListRolesOperationCompleted.ShouldNotBeNull();
            parametersOfOnListRolesOperationCompleted.Length.ShouldBe(1);
            methodOnListRolesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListRolesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListRolesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListRolesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListRolesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListRolesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListRolesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListRolesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListRolesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListRolesOperationCompleted);
            var methodOnListRolesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListRolesOperationCompleted, methodOnListRolesOperationCompletedParametersTypes);

            // Assert
            methodOnListRolesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListRolesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListRolesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListRolesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListRolesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRole) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateRole_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRole);
            var Name = this.CreateType<string>();
            var Description = this.CreateType<string>();
            var Tasks = this.CreateType<Task[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateRole(Name, Description, Tasks);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateRole) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateRole_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRole);
            var Name = this.CreateType<string>();
            var Description = this.CreateType<string>();
            var Tasks = this.CreateType<Task[]>();
            var methodCreateRoleParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Task[]) };
            object[] parametersOfCreateRole = { Name, Description, Tasks };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRole, methodCreateRoleParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfCreateRole);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateRole.ShouldNotBeNull();
            parametersOfCreateRole.Length.ShouldBe(3);
            methodCreateRoleParametersTypes.Length.ShouldBe(3);
            methodCreateRoleParametersTypes.Length.ShouldBe(parametersOfCreateRole.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateRole) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateRole_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRole);
            var Name = this.CreateType<string>();
            var Description = this.CreateType<string>();
            var Tasks = this.CreateType<Task[]>();
            var methodCreateRoleParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Task[]) };
            object[] parametersOfCreateRole = { Name, Description, Tasks };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateRole, parametersOfCreateRole, methodCreateRoleParametersTypes);

            // Assert
            parametersOfCreateRole.ShouldNotBeNull();
            parametersOfCreateRole.Length.ShouldBe(3);
            methodCreateRoleParametersTypes.Length.ShouldBe(3);
            methodCreateRoleParametersTypes.Length.ShouldBe(parametersOfCreateRole.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRole) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateRole_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRole);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRole, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRole) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateRole_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRole);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRole, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateRoleOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateRoleOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateRoleOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateRoleOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateRoleOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateRoleOperationCompleted, parametersOfOnCreateRoleOperationCompleted, methodOnCreateRoleOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateRoleOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateRoleOperationCompleted.Length.ShouldBe(1);
            methodOnCreateRoleOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateRoleOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateRoleOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateRoleOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateRoleOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateRoleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateRoleOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateRoleOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateRoleOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateRoleOperationCompleted);
            var methodOnCreateRoleOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateRoleOperationCompleted, methodOnCreateRoleOperationCompletedParametersTypes);

            // Assert
            methodOnCreateRoleOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateRoleOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateRoleOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateRoleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateRoleOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (DeleteRole) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteRole_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteRole);
            var Name = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.DeleteRole(Name);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteRole) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteRole_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteRole);
            var Name = this.CreateType<string>();
            var methodDeleteRoleParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDeleteRole = { Name };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteRole, methodDeleteRoleParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfDeleteRole);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteRole.ShouldNotBeNull();
            parametersOfDeleteRole.Length.ShouldBe(1);
            methodDeleteRoleParametersTypes.Length.ShouldBe(1);
            methodDeleteRoleParametersTypes.Length.ShouldBe(parametersOfDeleteRole.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DeleteRole) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteRole_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteRole);
            var Name = this.CreateType<string>();
            var methodDeleteRoleParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDeleteRole = { Name };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteRole, parametersOfDeleteRole, methodDeleteRoleParametersTypes);

            // Assert
            parametersOfDeleteRole.ShouldNotBeNull();
            parametersOfDeleteRole.Length.ShouldBe(1);
            methodDeleteRoleParametersTypes.Length.ShouldBe(1);
            methodDeleteRoleParametersTypes.Length.ShouldBe(parametersOfDeleteRole.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteRole) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteRole_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteRole);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteRole, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteRole) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteRole_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteRole);
            var methodDeleteRoleParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteRole, methodDeleteRoleParametersTypes);

            // Assert
            methodDeleteRoleParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteRole) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteRole_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteRole);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteRole, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnDeleteRoleOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteRoleOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteRoleOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnDeleteRoleOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnDeleteRoleOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnDeleteRoleOperationCompleted, parametersOfOnDeleteRoleOperationCompleted, methodOnDeleteRoleOperationCompletedParametersTypes);

            // Assert
            parametersOfOnDeleteRoleOperationCompleted.ShouldNotBeNull();
            parametersOfOnDeleteRoleOperationCompleted.Length.ShouldBe(1);
            methodOnDeleteRoleOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnDeleteRoleOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnDeleteRoleOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteRoleOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteRoleOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteRoleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteRoleOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnDeleteRoleOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteRoleOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteRoleOperationCompleted);
            var methodOnDeleteRoleOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnDeleteRoleOperationCompleted, methodOnDeleteRoleOperationCompletedParametersTypes);

            // Assert
            methodOnDeleteRoleOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteRoleOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteRoleOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteRoleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteRoleOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetRoleProperties) (Return Type : Task[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRoleProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRoleProperties);
            var Name = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetRoleProperties(Name, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRoleProperties) (Return Type : Task[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRoleProperties_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRoleProperties);
            var Name = this.CreateType<string>();
            var returnedValue = default(Task[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetRoleProperties(Name, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRoleProperties) (Return Type : Task[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRoleProperties_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRoleProperties);
            var Name = this.CreateType<string>();
            var Description = this.CreateType<string>();
            var methodGetRolePropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetRoleProperties = { Name, Description };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRoleProperties, methodGetRolePropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Task[]>(_reportingService2005InstanceFixture, parametersOfGetRoleProperties);
            var result2 = this.GetResultOfMethod<Task[]>(MethodGetRoleProperties, parametersOfGetRoleProperties, methodGetRolePropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRoleProperties.ShouldNotBeNull();
            parametersOfGetRoleProperties.Length.ShouldBe(2);
            methodGetRolePropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetRoleProperties) (Return Type : Task[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRoleProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRoleProperties);
            var Name = this.CreateType<string>();
            var Description = this.CreateType<string>();
            var methodGetRolePropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetRoleProperties = { Name, Description };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Task[]>(MethodGetRoleProperties, parametersOfGetRoleProperties, methodGetRolePropertiesParametersTypes);

            // Assert
            parametersOfGetRoleProperties.ShouldNotBeNull();
            parametersOfGetRoleProperties.Length.ShouldBe(2);
            methodGetRolePropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRoleProperties) (Return Type : Task[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRoleProperties_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRoleProperties);
            var methodGetRolePropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRoleProperties, methodGetRolePropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRolePropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetRoleProperties) (Return Type : Task[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRoleProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRoleProperties);
            var methodGetRolePropertiesParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRoleProperties, methodGetRolePropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRolePropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRoleProperties) (Return Type : Task[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRoleProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRoleProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRoleProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRoleProperties) (Return Type : Task[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRoleProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRoleProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRoleProperties, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetRolePropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetRolePropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetRolePropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetRolePropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetRolePropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetRolePropertiesOperationCompleted, parametersOfOnGetRolePropertiesOperationCompleted, methodOnGetRolePropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetRolePropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetRolePropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetRolePropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetRolePropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetRolePropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetRolePropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetRolePropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetRolePropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetRolePropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetRolePropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetRolePropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetRolePropertiesOperationCompleted);
            var methodOnGetRolePropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetRolePropertiesOperationCompleted, methodOnGetRolePropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnGetRolePropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetRolePropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetRolePropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetRolePropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetRolePropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetRoleProperties) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetRoleProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetRoleProperties);
            var Name = this.CreateType<string>();
            var Description = this.CreateType<string>();
            var Tasks = this.CreateType<Task[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetRoleProperties(Name, Description, Tasks);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetRoleProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetRoleProperties_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetRoleProperties);
            var Name = this.CreateType<string>();
            var Description = this.CreateType<string>();
            var Tasks = this.CreateType<Task[]>();
            var methodSetRolePropertiesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Task[]) };
            object[] parametersOfSetRoleProperties = { Name, Description, Tasks };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetRoleProperties, methodSetRolePropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetRoleProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetRoleProperties.ShouldNotBeNull();
            parametersOfSetRoleProperties.Length.ShouldBe(3);
            methodSetRolePropertiesParametersTypes.Length.ShouldBe(3);
            methodSetRolePropertiesParametersTypes.Length.ShouldBe(parametersOfSetRoleProperties.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetRoleProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetRoleProperties_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetRoleProperties);
            var Name = this.CreateType<string>();
            var Description = this.CreateType<string>();
            var Tasks = this.CreateType<Task[]>();
            var methodSetRolePropertiesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Task[]) };
            object[] parametersOfSetRoleProperties = { Name, Description, Tasks };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetRoleProperties, parametersOfSetRoleProperties, methodSetRolePropertiesParametersTypes);

            // Assert
            parametersOfSetRoleProperties.ShouldNotBeNull();
            parametersOfSetRoleProperties.Length.ShouldBe(3);
            methodSetRolePropertiesParametersTypes.Length.ShouldBe(3);
            methodSetRolePropertiesParametersTypes.Length.ShouldBe(parametersOfSetRoleProperties.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetRoleProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetRoleProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetRoleProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetRoleProperties, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetRoleProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetRoleProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetRoleProperties);
            var methodSetRolePropertiesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Task[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetRoleProperties, methodSetRolePropertiesParametersTypes);

            // Assert
            methodSetRolePropertiesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetRoleProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetRoleProperties_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetRoleProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetRoleProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetRolePropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetRolePropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetRolePropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetRolePropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetRolePropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetRolePropertiesOperationCompleted, parametersOfOnSetRolePropertiesOperationCompleted, methodOnSetRolePropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetRolePropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetRolePropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnSetRolePropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetRolePropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetRolePropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetRolePropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetRolePropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetRolePropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetRolePropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetRolePropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetRolePropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetRolePropertiesOperationCompleted);
            var methodOnSetRolePropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetRolePropertiesOperationCompleted, methodOnSetRolePropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnSetRolePropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetRolePropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetRolePropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetRolePropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetRolePropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetSystemPolicies) (Return Type : Policy[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPolicies_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPolicies);

            // Act
            Action executeAction = () => _reportingService2005Instance.GetSystemPolicies();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSystemPolicies) (Return Type : Policy[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPolicies_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPolicies);
            var returnedValue = default(Policy[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetSystemPolicies();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemPolicies) (Return Type : Policy[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPolicies_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPolicies);
            Type [] methodGetSystemPoliciesParametersTypes = null;
            object[] parametersOfGetSystemPolicies = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemPolicies, methodGetSystemPoliciesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Policy[]>(_reportingService2005InstanceFixture, parametersOfGetSystemPolicies);
            var result2 = this.GetResultOfMethod<Policy[]>(MethodGetSystemPolicies, parametersOfGetSystemPolicies, methodGetSystemPoliciesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSystemPolicies.ShouldBeNull();
            methodGetSystemPoliciesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemPolicies) (Return Type : Policy[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPolicies_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPolicies);
            Type [] methodGetSystemPoliciesParametersTypes = null;
            object[] parametersOfGetSystemPolicies = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Policy[]>(MethodGetSystemPolicies, parametersOfGetSystemPolicies, methodGetSystemPoliciesParametersTypes);

            // Assert
            parametersOfGetSystemPolicies.ShouldBeNull();
            methodGetSystemPoliciesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemPolicies) (Return Type : Policy[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPolicies_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPolicies);
            Type [] methodGetSystemPoliciesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSystemPolicies, methodGetSystemPoliciesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSystemPoliciesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemPolicies) (Return Type : Policy[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPolicies_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPolicies);
            Type [] methodGetSystemPoliciesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSystemPolicies, methodGetSystemPoliciesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSystemPoliciesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemPolicies) (Return Type : Policy[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPolicies_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemPolicies, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (OnGetSystemPoliciesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSystemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSystemPoliciesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetSystemPoliciesOperationCompleted, parametersOfOnGetSystemPoliciesOperationCompleted, methodOnGetSystemPoliciesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetSystemPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSystemPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnGetSystemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSystemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSystemPoliciesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSystemPoliciesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPoliciesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSystemPoliciesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSystemPoliciesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPoliciesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPoliciesOperationCompleted);
            var methodOnGetSystemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetSystemPoliciesOperationCompleted, methodOnGetSystemPoliciesOperationCompletedParametersTypes);

            // Assert
            methodOnGetSystemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSystemPoliciesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPoliciesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSystemPoliciesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetSystemPolicies) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemPolicies_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemPolicies);
            var Policies = this.CreateType<Policy[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetSystemPolicies(Policies);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSystemPolicies) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemPolicies_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemPolicies);
            var Policies = this.CreateType<Policy[]>();
            var methodSetSystemPoliciesParametersTypes = new Type[] { typeof(Policy[]) };
            object[] parametersOfSetSystemPolicies = { Policies };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSystemPolicies, methodSetSystemPoliciesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetSystemPolicies);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSystemPolicies.ShouldNotBeNull();
            parametersOfSetSystemPolicies.Length.ShouldBe(1);
            methodSetSystemPoliciesParametersTypes.Length.ShouldBe(1);
            methodSetSystemPoliciesParametersTypes.Length.ShouldBe(parametersOfSetSystemPolicies.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSystemPolicies) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemPolicies_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemPolicies);
            var Policies = this.CreateType<Policy[]>();
            var methodSetSystemPoliciesParametersTypes = new Type[] { typeof(Policy[]) };
            object[] parametersOfSetSystemPolicies = { Policies };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSystemPolicies, parametersOfSetSystemPolicies, methodSetSystemPoliciesParametersTypes);

            // Assert
            parametersOfSetSystemPolicies.ShouldNotBeNull();
            parametersOfSetSystemPolicies.Length.ShouldBe(1);
            methodSetSystemPoliciesParametersTypes.Length.ShouldBe(1);
            methodSetSystemPoliciesParametersTypes.Length.ShouldBe(parametersOfSetSystemPolicies.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSystemPolicies) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemPolicies_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSystemPolicies, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSystemPolicies) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemPolicies_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemPolicies);
            var methodSetSystemPoliciesParametersTypes = new Type[] { typeof(Policy[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSystemPolicies, methodSetSystemPoliciesParametersTypes);

            // Assert
            methodSetSystemPoliciesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSystemPolicies) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemPolicies_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSystemPolicies, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSystemPoliciesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSystemPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSystemPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetSystemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetSystemPoliciesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetSystemPoliciesOperationCompleted, parametersOfOnSetSystemPoliciesOperationCompleted, methodOnSetSystemPoliciesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetSystemPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetSystemPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnSetSystemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetSystemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetSystemPoliciesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSystemPoliciesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSystemPoliciesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSystemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSystemPoliciesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetSystemPoliciesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSystemPoliciesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSystemPoliciesOperationCompleted);
            var methodOnSetSystemPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetSystemPoliciesOperationCompleted, methodOnSetSystemPoliciesOperationCompletedParametersTypes);

            // Assert
            methodOnSetSystemPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSystemPoliciesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSystemPoliciesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSystemPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSystemPoliciesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetPolicies) (Return Type : Policy[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPolicies_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicies);
            var Item = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetPolicies(Item, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetPolicies) (Return Type : Policy[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPolicies_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicies);
            var Item = this.CreateType<string>();
            var returnedValue = default(Policy[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetPolicies(Item, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPolicies) (Return Type : Policy[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPolicies_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicies);
            var Item = this.CreateType<string>();
            var InheritParent = this.CreateType<bool>();
            var methodGetPoliciesParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfGetPolicies = { Item, InheritParent };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPolicies, methodGetPoliciesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Policy[]>(_reportingService2005InstanceFixture, parametersOfGetPolicies);
            var result2 = this.GetResultOfMethod<Policy[]>(MethodGetPolicies, parametersOfGetPolicies, methodGetPoliciesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetPolicies.ShouldNotBeNull();
            parametersOfGetPolicies.Length.ShouldBe(2);
            methodGetPoliciesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetPolicies) (Return Type : Policy[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPolicies_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicies);
            var Item = this.CreateType<string>();
            var InheritParent = this.CreateType<bool>();
            var methodGetPoliciesParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfGetPolicies = { Item, InheritParent };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Policy[]>(MethodGetPolicies, parametersOfGetPolicies, methodGetPoliciesParametersTypes);

            // Assert
            parametersOfGetPolicies.ShouldNotBeNull();
            parametersOfGetPolicies.Length.ShouldBe(2);
            methodGetPoliciesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPolicies) (Return Type : Policy[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPolicies_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicies);
            var methodGetPoliciesParametersTypes = new Type[] { typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPolicies, methodGetPoliciesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPoliciesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetPolicies) (Return Type : Policy[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPolicies_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicies);
            var methodGetPoliciesParametersTypes = new Type[] { typeof(string), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPolicies, methodGetPoliciesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPoliciesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPolicies) (Return Type : Policy[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPolicies_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPolicies, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPolicies) (Return Type : Policy[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPolicies_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPolicies, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetPoliciesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetPoliciesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetPoliciesOperationCompleted, parametersOfOnGetPoliciesOperationCompleted, methodOnGetPoliciesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnGetPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetPoliciesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetPoliciesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPoliciesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetPoliciesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetPoliciesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPoliciesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPoliciesOperationCompleted);
            var methodOnGetPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetPoliciesOperationCompleted, methodOnGetPoliciesOperationCompletedParametersTypes);

            // Assert
            methodOnGetPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetPoliciesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPoliciesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetPoliciesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetPolicies) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetPolicies_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPolicies);
            var Item = this.CreateType<string>();
            var Policies = this.CreateType<Policy[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetPolicies(Item, Policies);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetPolicies) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetPolicies_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPolicies);
            var Item = this.CreateType<string>();
            var Policies = this.CreateType<Policy[]>();
            var methodSetPoliciesParametersTypes = new Type[] { typeof(string), typeof(Policy[]) };
            object[] parametersOfSetPolicies = { Item, Policies };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetPolicies, methodSetPoliciesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetPolicies);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetPolicies.ShouldNotBeNull();
            parametersOfSetPolicies.Length.ShouldBe(2);
            methodSetPoliciesParametersTypes.Length.ShouldBe(2);
            methodSetPoliciesParametersTypes.Length.ShouldBe(parametersOfSetPolicies.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetPolicies) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetPolicies_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPolicies);
            var Item = this.CreateType<string>();
            var Policies = this.CreateType<Policy[]>();
            var methodSetPoliciesParametersTypes = new Type[] { typeof(string), typeof(Policy[]) };
            object[] parametersOfSetPolicies = { Item, Policies };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetPolicies, parametersOfSetPolicies, methodSetPoliciesParametersTypes);

            // Assert
            parametersOfSetPolicies.ShouldNotBeNull();
            parametersOfSetPolicies.Length.ShouldBe(2);
            methodSetPoliciesParametersTypes.Length.ShouldBe(2);
            methodSetPoliciesParametersTypes.Length.ShouldBe(parametersOfSetPolicies.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPolicies) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetPolicies_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPolicies, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetPolicies) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetPolicies_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPolicies);
            var methodSetPoliciesParametersTypes = new Type[] { typeof(string), typeof(Policy[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetPolicies, methodSetPoliciesParametersTypes);

            // Assert
            methodSetPoliciesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetPolicies) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetPolicies_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetPolicies);
            var currentMethodInfo = this.GetMethodInfo(MethodSetPolicies, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetPoliciesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetPoliciesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetPoliciesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetPoliciesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetPoliciesOperationCompleted, parametersOfOnSetPoliciesOperationCompleted, methodOnSetPoliciesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetPoliciesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetPoliciesOperationCompleted.Length.ShouldBe(1);
            methodOnSetPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetPoliciesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetPoliciesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetPoliciesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetPoliciesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetPoliciesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetPoliciesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetPoliciesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetPoliciesOperationCompleted);
            var methodOnSetPoliciesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetPoliciesOperationCompleted, methodOnSetPoliciesOperationCompletedParametersTypes);

            // Assert
            methodOnSetPoliciesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetPoliciesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetPoliciesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetPoliciesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetPoliciesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (InheritParentSecurity) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritParentSecurity_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritParentSecurity);
            var Item = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.InheritParentSecurity(Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InheritParentSecurity) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritParentSecurity_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritParentSecurity);
            var Item = this.CreateType<string>();
            var methodInheritParentSecurityParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfInheritParentSecurity = { Item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInheritParentSecurity, methodInheritParentSecurityParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfInheritParentSecurity);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInheritParentSecurity.ShouldNotBeNull();
            parametersOfInheritParentSecurity.Length.ShouldBe(1);
            methodInheritParentSecurityParametersTypes.Length.ShouldBe(1);
            methodInheritParentSecurityParametersTypes.Length.ShouldBe(parametersOfInheritParentSecurity.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InheritParentSecurity) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritParentSecurity_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritParentSecurity);
            var Item = this.CreateType<string>();
            var methodInheritParentSecurityParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfInheritParentSecurity = { Item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInheritParentSecurity, parametersOfInheritParentSecurity, methodInheritParentSecurityParametersTypes);

            // Assert
            parametersOfInheritParentSecurity.ShouldNotBeNull();
            parametersOfInheritParentSecurity.Length.ShouldBe(1);
            methodInheritParentSecurityParametersTypes.Length.ShouldBe(1);
            methodInheritParentSecurityParametersTypes.Length.ShouldBe(parametersOfInheritParentSecurity.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InheritParentSecurity) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritParentSecurity_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritParentSecurity);
            var currentMethodInfo = this.GetMethodInfo(MethodInheritParentSecurity, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InheritParentSecurity) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritParentSecurity_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritParentSecurity);
            var methodInheritParentSecurityParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInheritParentSecurity, methodInheritParentSecurityParametersTypes);

            // Assert
            methodInheritParentSecurityParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InheritParentSecurity) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_InheritParentSecurity_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInheritParentSecurity);
            var currentMethodInfo = this.GetMethodInfo(MethodInheritParentSecurity, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnInheritParentSecurityOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnInheritParentSecurityOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnInheritParentSecurityOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnInheritParentSecurityOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnInheritParentSecurityOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnInheritParentSecurityOperationCompleted, parametersOfOnInheritParentSecurityOperationCompleted, methodOnInheritParentSecurityOperationCompletedParametersTypes);

            // Assert
            parametersOfOnInheritParentSecurityOperationCompleted.ShouldNotBeNull();
            parametersOfOnInheritParentSecurityOperationCompleted.Length.ShouldBe(1);
            methodOnInheritParentSecurityOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnInheritParentSecurityOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnInheritParentSecurityOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnInheritParentSecurityOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnInheritParentSecurityOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnInheritParentSecurityOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnInheritParentSecurityOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnInheritParentSecurityOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnInheritParentSecurityOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnInheritParentSecurityOperationCompleted);
            var methodOnInheritParentSecurityOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnInheritParentSecurityOperationCompleted, methodOnInheritParentSecurityOperationCompletedParametersTypes);

            // Assert
            methodOnInheritParentSecurityOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnInheritParentSecurityOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnInheritParentSecurityOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnInheritParentSecurityOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnInheritParentSecurityOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetSystemPermissions) (Return Type : string[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPermissions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPermissions);

            // Act
            Action executeAction = () => _reportingService2005Instance.GetSystemPermissions();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSystemPermissions) (Return Type : string[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPermissions_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPermissions);
            var returnedValue = default(string[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetSystemPermissions();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemPermissions) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPermissions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPermissions);
            Type [] methodGetSystemPermissionsParametersTypes = null;
            object[] parametersOfGetSystemPermissions = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemPermissions, methodGetSystemPermissionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string[]>(_reportingService2005InstanceFixture, parametersOfGetSystemPermissions);
            var result2 = this.GetResultOfMethod<string[]>(MethodGetSystemPermissions, parametersOfGetSystemPermissions, methodGetSystemPermissionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSystemPermissions.ShouldBeNull();
            methodGetSystemPermissionsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemPermissions) (Return Type : string[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPermissions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPermissions);
            Type [] methodGetSystemPermissionsParametersTypes = null;
            object[] parametersOfGetSystemPermissions = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[]>(MethodGetSystemPermissions, parametersOfGetSystemPermissions, methodGetSystemPermissionsParametersTypes);

            // Assert
            parametersOfGetSystemPermissions.ShouldBeNull();
            methodGetSystemPermissionsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemPermissions) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPermissions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPermissions);
            Type [] methodGetSystemPermissionsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSystemPermissions, methodGetSystemPermissionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSystemPermissionsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemPermissions) (Return Type : string[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPermissions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPermissions);
            Type [] methodGetSystemPermissionsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSystemPermissions, methodGetSystemPermissionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSystemPermissionsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemPermissions) (Return Type : string[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemPermissions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemPermissions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (OnGetSystemPermissionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPermissionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPermissionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSystemPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSystemPermissionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetSystemPermissionsOperationCompleted, parametersOfOnGetSystemPermissionsOperationCompleted, methodOnGetSystemPermissionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetSystemPermissionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSystemPermissionsOperationCompleted.Length.ShouldBe(1);
            methodOnGetSystemPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSystemPermissionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSystemPermissionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSystemPermissionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPermissionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPermissionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSystemPermissionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSystemPermissionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPermissionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPermissionsOperationCompleted);
            var methodOnGetSystemPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetSystemPermissionsOperationCompleted, methodOnGetSystemPermissionsOperationCompletedParametersTypes);

            // Assert
            methodOnGetSystemPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSystemPermissionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPermissionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPermissionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSystemPermissionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetPermissions) (Return Type : string[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPermissions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPermissions);
            var Item = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetPermissions(Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetPermissions) (Return Type : string[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPermissions_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPermissions);
            var Item = this.CreateType<string>();
            var returnedValue = default(string[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetPermissions(Item);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPermissions) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPermissions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPermissions);
            var Item = this.CreateType<string>();
            var methodGetPermissionsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetPermissions = { Item };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPermissions, methodGetPermissionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string[]>(_reportingService2005InstanceFixture, parametersOfGetPermissions);
            var result2 = this.GetResultOfMethod<string[]>(MethodGetPermissions, parametersOfGetPermissions, methodGetPermissionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetPermissions.ShouldNotBeNull();
            parametersOfGetPermissions.Length.ShouldBe(1);
            methodGetPermissionsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPermissions) (Return Type : string[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPermissions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPermissions);
            var Item = this.CreateType<string>();
            var methodGetPermissionsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetPermissions = { Item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[]>(MethodGetPermissions, parametersOfGetPermissions, methodGetPermissionsParametersTypes);

            // Assert
            parametersOfGetPermissions.ShouldNotBeNull();
            parametersOfGetPermissions.Length.ShouldBe(1);
            methodGetPermissionsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPermissions) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPermissions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPermissions);
            var methodGetPermissionsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPermissions, methodGetPermissionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPermissionsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPermissions) (Return Type : string[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPermissions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPermissions);
            var methodGetPermissionsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPermissions, methodGetPermissionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPermissionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPermissions) (Return Type : string[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPermissions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPermissions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPermissions) (Return Type : string[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetPermissions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPermissions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPermissions, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetPermissionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPermissionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPermissionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetPermissionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetPermissionsOperationCompleted, parametersOfOnGetPermissionsOperationCompleted, methodOnGetPermissionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetPermissionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetPermissionsOperationCompleted.Length.ShouldBe(1);
            methodOnGetPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetPermissionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetPermissionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetPermissionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPermissionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPermissionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetPermissionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetPermissionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPermissionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPermissionsOperationCompleted);
            var methodOnGetPermissionsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetPermissionsOperationCompleted, methodOnGetPermissionsOperationCompletedParametersTypes);

            // Assert
            methodOnGetPermissionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetPermissionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPermissionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPermissionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetPermissionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (LogonUser) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_LogonUser_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var authority = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.LogonUser(userName, password, authority);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_LogonUser_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var authority = this.CreateType<string>();
            var methodLogonUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfLogonUser = { userName, password, authority };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogonUser, methodLogonUserParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfLogonUser);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogonUser.ShouldNotBeNull();
            parametersOfLogonUser.Length.ShouldBe(3);
            methodLogonUserParametersTypes.Length.ShouldBe(3);
            methodLogonUserParametersTypes.Length.ShouldBe(parametersOfLogonUser.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_LogonUser_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var authority = this.CreateType<string>();
            var methodLogonUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfLogonUser = { userName, password, authority };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogonUser, parametersOfLogonUser, methodLogonUserParametersTypes);

            // Assert
            parametersOfLogonUser.ShouldNotBeNull();
            parametersOfLogonUser.Length.ShouldBe(3);
            methodLogonUserParametersTypes.Length.ShouldBe(3);
            methodLogonUserParametersTypes.Length.ShouldBe(parametersOfLogonUser.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_LogonUser_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var currentMethodInfo = this.GetMethodInfo(MethodLogonUser, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_LogonUser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var methodLogonUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogonUser, methodLogonUserParametersTypes);

            // Assert
            methodLogonUserParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_LogonUser_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var currentMethodInfo = this.GetMethodInfo(MethodLogonUser, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnLogonUserOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnLogonUserOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnLogonUserOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnLogonUserOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnLogonUserOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnLogonUserOperationCompleted, parametersOfOnLogonUserOperationCompleted, methodOnLogonUserOperationCompletedParametersTypes);

            // Assert
            parametersOfOnLogonUserOperationCompleted.ShouldNotBeNull();
            parametersOfOnLogonUserOperationCompleted.Length.ShouldBe(1);
            methodOnLogonUserOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnLogonUserOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnLogonUserOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnLogonUserOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnLogonUserOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnLogonUserOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnLogonUserOperationCompleted, 0);
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