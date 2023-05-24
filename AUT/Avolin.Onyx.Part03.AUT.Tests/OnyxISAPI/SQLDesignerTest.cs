using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.SQL" />)
    ///     and namespace <see cref="OnyxISAPI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SQLDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="SQLNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public SQLDesignerTest() : base(publicType: typeof(Common), classNameWithNamespace: SQLNonPublicTypeName)
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

        private Type _sQLInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string SQLNonPublicTypeName = "OnyxISAPI.SQL";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _sQLInstance;
        private object _sQLInstanceFixture;

        #region General Initializer : Class (SQL) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxISAPI.SQL" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _sQLInstanceFixture = this.CreateNonPublicType(SQLNonPublicTypeName);
            _sQLInstance = _sQLInstanceFixture;
            CurrentInstance = _sQLInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SQL) Initializer

        #region Properties

        private const string PropertyResourceManager = "ResourceManager";
        private const string PropertyCulture = "Culture";
        private const string PropertyCOMP_SEL_02 = "COMP_SEL_02";
        private const string PropertyCOMP_SEL_03 = "COMP_SEL_03";
        private const string PropertyCOMP_SEL_04 = "COMP_SEL_04";
        private const string PropertyCOMP_SEL_05 = "COMP_SEL_05";
        private const string PropertyCOMP_SEL_06 = "COMP_SEL_06";
        private const string PropertyCOMP_SEL_07 = "COMP_SEL_07";
        private const string PropertyCOMP_SEL_08 = "COMP_SEL_08";
        private const string PropertyENTITY_SRCH = "ENTITY_SRCH";
        private const string PropertyFCST_SEL_02 = "FCST_SEL_02";
        private const string PropertyFCST_SEL_03 = "FCST_SEL_03";
        private const string PropertyFCST_SEL_04 = "FCST_SEL_04";
        private const string PropertyINDV_SEL_02 = "INDV_SEL_02";
        private const string PropertyINDV_SEL_03 = "INDV_SEL_03";
        private const string PropertyINDV_SEL_04 = "INDV_SEL_04";
        private const string PropertyINDV_SEL_05 = "INDV_SEL_05";
        private const string PropertyINDV_SEL_06 = "INDV_SEL_06";
        private const string PropertyINDV_SEL_07 = "INDV_SEL_07";
        private const string PropertySOPR_SEL_02 = "SOPR_SEL_02";
        private const string PropertySOPR_SEL_03 = "SOPR_SEL_03";
        private const string PropertySOPR_SEL_04 = "SOPR_SEL_04";
        private const string PropertySOPR_SEL_05 = "SOPR_SEL_05";
        private const string PropertySOPR_SEL_06 = "SOPR_SEL_06";
        private const string PropertySPIN_SEL_02 = "SPIN_SEL_02";
        private const string PropertySPIN_SEL_03 = "SPIN_SEL_03";
        private const string PropertySPIN_SEL_04 = "SPIN_SEL_04";
        private const string PropertySPIN_SEL_05 = "SPIN_SEL_05";
        private const string PropertySPIN_SEL_06 = "SPIN_SEL_06";
        private const string PropertySVRQ_SEL_02 = "SVRQ_SEL_02";
        private const string PropertySVRQ_SEL_03 = "SVRQ_SEL_03";
        private const string PropertySVRQ_SEL_04 = "SVRQ_SEL_04";
        private const string PropertySVRQ_SEL_05 = "SVRQ_SEL_05";
        private const string PropertySVRQ_SEL_06 = "SVRQ_SEL_06";
        private const string PropertyTASK_SEL_02 = "TASK_SEL_02";
        private const string PropertyTASK_SEL_03 = "TASK_SEL_03";
        private const string PropertyTASK_SEL_04 = "TASK_SEL_04";
        private const string PropertyTASK_SEL_05 = "TASK_SEL_05";
        private const string PropertyTASK_SEL_06 = "TASK_SEL_06";
        private const string PropertyTASK_SEL_07 = "TASK_SEL_07";
        private const string PropertyWRTK_SEL_02 = "WRTK_SEL_02";
        private const string PropertyWRTK_SEL_03 = "WRTK_SEL_03";
        private const string PropertyWRTK_SEL_04 = "WRTK_SEL_04";
        private const string PropertyWRTK_SEL_05 = "WRTK_SEL_05";
        private const string PropertyWRTK_SEL_06 = "WRTK_SEL_06";

        #endregion

        #region Fields

        private const string FieldresourceMan = "resourceMan";
        private const string FieldresourceCulture = "resourceCulture";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (SQL)

        #region General Initializer : Class (SQL) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxISAPI.SQL" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SQLDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SQL) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxISAPI.SQL" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyCOMP_SEL_02)]
        [TestCase(PropertyCOMP_SEL_03)]
        [TestCase(PropertyCOMP_SEL_04)]
        [TestCase(PropertyCOMP_SEL_05)]
        [TestCase(PropertyCOMP_SEL_06)]
        [TestCase(PropertyCOMP_SEL_07)]
        [TestCase(PropertyCOMP_SEL_08)]
        [TestCase(PropertyENTITY_SRCH)]
        [TestCase(PropertyFCST_SEL_02)]
        [TestCase(PropertyFCST_SEL_03)]
        [TestCase(PropertyFCST_SEL_04)]
        [TestCase(PropertyINDV_SEL_02)]
        [TestCase(PropertyINDV_SEL_03)]
        [TestCase(PropertyINDV_SEL_04)]
        [TestCase(PropertyINDV_SEL_05)]
        [TestCase(PropertyINDV_SEL_06)]
        [TestCase(PropertyINDV_SEL_07)]
        [TestCase(PropertySOPR_SEL_02)]
        [TestCase(PropertySOPR_SEL_03)]
        [TestCase(PropertySOPR_SEL_04)]
        [TestCase(PropertySOPR_SEL_05)]
        [TestCase(PropertySOPR_SEL_06)]
        [TestCase(PropertySPIN_SEL_02)]
        [TestCase(PropertySPIN_SEL_03)]
        [TestCase(PropertySPIN_SEL_04)]
        [TestCase(PropertySPIN_SEL_05)]
        [TestCase(PropertySPIN_SEL_06)]
        [TestCase(PropertySVRQ_SEL_02)]
        [TestCase(PropertySVRQ_SEL_03)]
        [TestCase(PropertySVRQ_SEL_04)]
        [TestCase(PropertySVRQ_SEL_05)]
        [TestCase(PropertySVRQ_SEL_06)]
        [TestCase(PropertyTASK_SEL_02)]
        [TestCase(PropertyTASK_SEL_03)]
        [TestCase(PropertyTASK_SEL_04)]
        [TestCase(PropertyTASK_SEL_05)]
        [TestCase(PropertyTASK_SEL_06)]
        [TestCase(PropertyTASK_SEL_07)]
        [TestCase(PropertyWRTK_SEL_02)]
        [TestCase(PropertyWRTK_SEL_03)]
        [TestCase(PropertyWRTK_SEL_04)]
        [TestCase(PropertyWRTK_SEL_05)]
        [TestCase(PropertyWRTK_SEL_06)]
        [Category("AUT Property")]
        public void AUT_SQLDesigner_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SQL) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxISAPI.SQL" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SQLDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (SQL) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxISAPI.SQL" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldresourceMan)]
        [TestCase(FieldresourceCulture)]
        [Category("AUT Fields")]
        public void AUT_SQLDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SQL) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxISAPI.SQL" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SQLDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SQL) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyCOMP_SEL_02)]
        [TestCase(PropertyCOMP_SEL_03)]
        [TestCase(PropertyCOMP_SEL_04)]
        [TestCase(PropertyCOMP_SEL_05)]
        [TestCase(PropertyCOMP_SEL_06)]
        [TestCase(PropertyCOMP_SEL_07)]
        [TestCase(PropertyCOMP_SEL_08)]
        [TestCase(PropertyENTITY_SRCH)]
        [TestCase(PropertyFCST_SEL_02)]
        [TestCase(PropertyFCST_SEL_03)]
        [TestCase(PropertyFCST_SEL_04)]
        [TestCase(PropertyINDV_SEL_02)]
        [TestCase(PropertyINDV_SEL_03)]
        [TestCase(PropertyINDV_SEL_04)]
        [TestCase(PropertyINDV_SEL_05)]
        [TestCase(PropertyINDV_SEL_06)]
        [TestCase(PropertyINDV_SEL_07)]
        [TestCase(PropertySOPR_SEL_02)]
        [TestCase(PropertySOPR_SEL_03)]
        [TestCase(PropertySOPR_SEL_04)]
        [TestCase(PropertySOPR_SEL_05)]
        [TestCase(PropertySOPR_SEL_06)]
        [TestCase(PropertySPIN_SEL_02)]
        [TestCase(PropertySPIN_SEL_03)]
        [TestCase(PropertySPIN_SEL_04)]
        [TestCase(PropertySPIN_SEL_05)]
        [TestCase(PropertySPIN_SEL_06)]
        [TestCase(PropertySVRQ_SEL_02)]
        [TestCase(PropertySVRQ_SEL_03)]
        [TestCase(PropertySVRQ_SEL_04)]
        [TestCase(PropertySVRQ_SEL_05)]
        [TestCase(PropertySVRQ_SEL_06)]
        [TestCase(PropertyTASK_SEL_02)]
        [TestCase(PropertyTASK_SEL_03)]
        [TestCase(PropertyTASK_SEL_04)]
        [TestCase(PropertyTASK_SEL_05)]
        [TestCase(PropertyTASK_SEL_06)]
        [TestCase(PropertyTASK_SEL_07)]
        [TestCase(PropertyWRTK_SEL_02)]
        [TestCase(PropertyWRTK_SEL_03)]
        [TestCase(PropertyWRTK_SEL_04)]
        [TestCase(PropertyWRTK_SEL_05)]
        [TestCase(PropertyWRTK_SEL_06)]
        public void AUT_SQLDesigner_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SQL) => Property (COMP_SEL_02) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_COMP_SEL_02_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCOMP_SEL_02);
            var propertyInfo = this.GetPropertyInfo(PropertyCOMP_SEL_02);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (COMP_SEL_03) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_COMP_SEL_03_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCOMP_SEL_03);
            var propertyInfo = this.GetPropertyInfo(PropertyCOMP_SEL_03);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (COMP_SEL_04) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_COMP_SEL_04_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCOMP_SEL_04);
            var propertyInfo = this.GetPropertyInfo(PropertyCOMP_SEL_04);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (COMP_SEL_05) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_COMP_SEL_05_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCOMP_SEL_05);
            var propertyInfo = this.GetPropertyInfo(PropertyCOMP_SEL_05);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (COMP_SEL_06) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_COMP_SEL_06_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCOMP_SEL_06);
            var propertyInfo = this.GetPropertyInfo(PropertyCOMP_SEL_06);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (COMP_SEL_07) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_COMP_SEL_07_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCOMP_SEL_07);
            var propertyInfo = this.GetPropertyInfo(PropertyCOMP_SEL_07);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (COMP_SEL_08) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_COMP_SEL_08_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCOMP_SEL_08);
            var propertyInfo = this.GetPropertyInfo(PropertyCOMP_SEL_08);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (Culture) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Culture_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCulture);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCulture);
            Action currentAction = () => propertyInfo.SetValue(_sQLInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (Culture) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_Culture_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCulture);
            var propertyInfo = this.GetPropertyInfo(PropertyCulture);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (ENTITY_SRCH) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_ENTITY_SRCH_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyENTITY_SRCH);
            var propertyInfo = this.GetPropertyInfo(PropertyENTITY_SRCH);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (FCST_SEL_02) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_FCST_SEL_02_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFCST_SEL_02);
            var propertyInfo = this.GetPropertyInfo(PropertyFCST_SEL_02);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (FCST_SEL_03) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_FCST_SEL_03_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFCST_SEL_03);
            var propertyInfo = this.GetPropertyInfo(PropertyFCST_SEL_03);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (FCST_SEL_04) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_FCST_SEL_04_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFCST_SEL_04);
            var propertyInfo = this.GetPropertyInfo(PropertyFCST_SEL_04);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (INDV_SEL_02) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_INDV_SEL_02_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyINDV_SEL_02);
            var propertyInfo = this.GetPropertyInfo(PropertyINDV_SEL_02);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (INDV_SEL_03) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_INDV_SEL_03_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyINDV_SEL_03);
            var propertyInfo = this.GetPropertyInfo(PropertyINDV_SEL_03);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (INDV_SEL_04) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_INDV_SEL_04_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyINDV_SEL_04);
            var propertyInfo = this.GetPropertyInfo(PropertyINDV_SEL_04);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (INDV_SEL_05) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_INDV_SEL_05_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyINDV_SEL_05);
            var propertyInfo = this.GetPropertyInfo(PropertyINDV_SEL_05);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (INDV_SEL_06) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_INDV_SEL_06_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyINDV_SEL_06);
            var propertyInfo = this.GetPropertyInfo(PropertyINDV_SEL_06);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (INDV_SEL_07) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_INDV_SEL_07_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyINDV_SEL_07);
            var propertyInfo = this.GetPropertyInfo(PropertyINDV_SEL_07);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (ResourceManager) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_ResourceManager_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceManager);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResourceManager);
            Action currentAction = () => propertyInfo.SetValue(_sQLInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (ResourceManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_ResourceManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceManager);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceManager);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SOPR_SEL_02) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SOPR_SEL_02_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySOPR_SEL_02);
            var propertyInfo = this.GetPropertyInfo(PropertySOPR_SEL_02);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SOPR_SEL_03) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SOPR_SEL_03_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySOPR_SEL_03);
            var propertyInfo = this.GetPropertyInfo(PropertySOPR_SEL_03);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SOPR_SEL_04) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SOPR_SEL_04_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySOPR_SEL_04);
            var propertyInfo = this.GetPropertyInfo(PropertySOPR_SEL_04);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SOPR_SEL_05) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SOPR_SEL_05_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySOPR_SEL_05);
            var propertyInfo = this.GetPropertyInfo(PropertySOPR_SEL_05);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SOPR_SEL_06) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SOPR_SEL_06_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySOPR_SEL_06);
            var propertyInfo = this.GetPropertyInfo(PropertySOPR_SEL_06);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SPIN_SEL_02) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SPIN_SEL_02_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySPIN_SEL_02);
            var propertyInfo = this.GetPropertyInfo(PropertySPIN_SEL_02);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SPIN_SEL_03) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SPIN_SEL_03_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySPIN_SEL_03);
            var propertyInfo = this.GetPropertyInfo(PropertySPIN_SEL_03);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SPIN_SEL_04) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SPIN_SEL_04_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySPIN_SEL_04);
            var propertyInfo = this.GetPropertyInfo(PropertySPIN_SEL_04);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SPIN_SEL_05) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SPIN_SEL_05_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySPIN_SEL_05);
            var propertyInfo = this.GetPropertyInfo(PropertySPIN_SEL_05);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SPIN_SEL_06) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SPIN_SEL_06_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySPIN_SEL_06);
            var propertyInfo = this.GetPropertyInfo(PropertySPIN_SEL_06);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SVRQ_SEL_02) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SVRQ_SEL_02_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySVRQ_SEL_02);
            var propertyInfo = this.GetPropertyInfo(PropertySVRQ_SEL_02);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SVRQ_SEL_03) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SVRQ_SEL_03_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySVRQ_SEL_03);
            var propertyInfo = this.GetPropertyInfo(PropertySVRQ_SEL_03);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SVRQ_SEL_04) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SVRQ_SEL_04_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySVRQ_SEL_04);
            var propertyInfo = this.GetPropertyInfo(PropertySVRQ_SEL_04);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SVRQ_SEL_05) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SVRQ_SEL_05_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySVRQ_SEL_05);
            var propertyInfo = this.GetPropertyInfo(PropertySVRQ_SEL_05);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (SVRQ_SEL_06) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_SVRQ_SEL_06_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySVRQ_SEL_06);
            var propertyInfo = this.GetPropertyInfo(PropertySVRQ_SEL_06);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (TASK_SEL_02) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_TASK_SEL_02_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTASK_SEL_02);
            var propertyInfo = this.GetPropertyInfo(PropertyTASK_SEL_02);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (TASK_SEL_03) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_TASK_SEL_03_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTASK_SEL_03);
            var propertyInfo = this.GetPropertyInfo(PropertyTASK_SEL_03);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (TASK_SEL_04) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_TASK_SEL_04_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTASK_SEL_04);
            var propertyInfo = this.GetPropertyInfo(PropertyTASK_SEL_04);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (TASK_SEL_05) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_TASK_SEL_05_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTASK_SEL_05);
            var propertyInfo = this.GetPropertyInfo(PropertyTASK_SEL_05);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (TASK_SEL_06) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_TASK_SEL_06_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTASK_SEL_06);
            var propertyInfo = this.GetPropertyInfo(PropertyTASK_SEL_06);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (TASK_SEL_07) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_TASK_SEL_07_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTASK_SEL_07);
            var propertyInfo = this.GetPropertyInfo(PropertyTASK_SEL_07);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (WRTK_SEL_02) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_WRTK_SEL_02_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWRTK_SEL_02);
            var propertyInfo = this.GetPropertyInfo(PropertyWRTK_SEL_02);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (WRTK_SEL_03) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_WRTK_SEL_03_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWRTK_SEL_03);
            var propertyInfo = this.GetPropertyInfo(PropertyWRTK_SEL_03);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (WRTK_SEL_04) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_WRTK_SEL_04_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWRTK_SEL_04);
            var propertyInfo = this.GetPropertyInfo(PropertyWRTK_SEL_04);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (WRTK_SEL_05) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_WRTK_SEL_05_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWRTK_SEL_05);
            var propertyInfo = this.GetPropertyInfo(PropertyWRTK_SEL_05);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SQL) => Property (WRTK_SEL_06) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SQLDesigner_Public_Class_WRTK_SEL_06_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWRTK_SEL_06);
            var propertyInfo = this.GetPropertyInfo(PropertyWRTK_SEL_06);

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