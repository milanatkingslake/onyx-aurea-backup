using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxWindowsService;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxWindowsService
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxWindowsService.OnyxServiceInstaller" />)
    ///     and namespace <see cref="OnyxWindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxServiceInstallerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxServiceInstaller" />)
        /// </summary>
        public OnyxServiceInstallerTest() : base(typeof(OnyxServiceInstaller))
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

        #region General Initializer : Class (OnyxServiceInstaller) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxServiceInstallerInstanceType;
        private OnyxServiceInstaller _onyxServiceInstallerInstance;
        private OnyxServiceInstaller _onyxServiceInstallerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxServiceInstaller" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxServiceInstallerInstanceType = typeof(OnyxServiceInstaller);
            _onyxServiceInstallerInstanceFixture = this.Create<OnyxServiceInstaller>(false);
            _onyxServiceInstallerInstance = _onyxServiceInstallerInstanceFixture ?? this.Create<OnyxServiceInstaller>(true);
            CurrentInstance = _onyxServiceInstallerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxServiceInstaller) Initializer

        #region Properties

        private const string PropertyServiceName = "ServiceName";
        private const string PropertyDisplayName = "DisplayName";
        private const string PropertyDescription = "Description";
        private const string PropertyStartType = "StartType";
        private const string PropertyAccount = "Account";
        private const string PropertyServiceUsername = "ServiceUsername";
        private const string PropertyServicePassword = "ServicePassword";

        #endregion

        #region Methods

        private const string MethodServiceInstaller_Committed = "ServiceInstaller_Committed";
        private const string MethodGetContextParameter = "GetContextParameter";
        private const string MethodOnBeforeInstall = "OnBeforeInstall";
        private const string MethodOnBeforeUninstall = "OnBeforeUninstall";

        #endregion

        #region Fields

        private const string FieldlogSource = "logSource";
        private const string FieldprocessInstaller = "processInstaller";
        private const string FieldserviceInstaller = "serviceInstaller";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxServiceInstaller)

        #region General Initializer : Class (OnyxServiceInstaller) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxServiceInstaller" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodServiceInstaller_Committed, 0)]
        [TestCase(MethodGetContextParameter, 0)]
        [TestCase(MethodOnBeforeInstall, 0)]
        [TestCase(MethodOnBeforeUninstall, 0)]
        public void AUT_OnyxServiceInstaller_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxServiceInstaller) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxServiceInstaller" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyServiceName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyStartType)]
        [TestCase(PropertyAccount)]
        [TestCase(PropertyServiceUsername)]
        [TestCase(PropertyServicePassword)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_OnyxServiceInstaller_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxServiceInstaller) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxServiceInstaller" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldlogSource)]
        [TestCase(FieldprocessInstaller)]
        [TestCase(FieldserviceInstaller)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_OnyxServiceInstaller_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxServiceInstaller) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyServiceName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyStartType)]
        [TestCase(PropertyAccount)]
        [TestCase(PropertyServiceUsername)]
        [TestCase(PropertyServicePassword)]
        public void AUT_OnyxServiceInstaller_Property_Exist_By_Name_Verify_Test(string name)
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

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetContextParameter) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxServiceInstaller_GetContextParameter_Method_Call_Internally(Type[] types)
        {
            var methodGetContextParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContextParameter, methodGetContextParameterParametersTypes);
        }

        #endregion

        #region Method Call : (OnBeforeInstall) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxServiceInstaller_OnBeforeInstall_Method_Call_Internally(Type[] types)
        {
            var methodOnBeforeInstallParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnBeforeInstall, methodOnBeforeInstallParametersTypes);
        }

        #endregion

        #region Method Call : (OnBeforeUninstall) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxServiceInstaller_OnBeforeUninstall_Method_Call_Internally(Type[] types)
        {
            var methodOnBeforeUninstallParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnBeforeUninstall, methodOnBeforeUninstallParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}