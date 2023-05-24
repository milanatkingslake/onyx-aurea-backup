using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.LogicalObject" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LogicalObjectTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="LogicalObjectNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public LogicalObjectTest() : base(publicType: typeof(Common), classNameWithNamespace: LogicalObjectNonPublicTypeName)
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

        private Type _logicalObjectInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string LogicalObjectNonPublicTypeName = "Onyx.Custom.LogicalObject";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _logicalObjectInstance;
        private object _logicalObjectInstanceFixture;

        #region General Initializer : Class (LogicalObject) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="LogicalObject" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _logicalObjectInstanceFixture = this.CreateNonPublicType(LogicalObjectNonPublicTypeName);
            _logicalObjectInstance = _logicalObjectInstanceFixture;
            CurrentInstance = _logicalObjectInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LogicalObject) Initializer

        #region Properties

        private const string PropertyDependentObjects = "DependentObjects";
        private const string PropertyobjectId = "objectId";
        private const string PropertyLBO = "LBO";
        private const string PropertyinsertLBM = "insertLBM";
        private const string PropertyupdateLBM = "updateLBM";
        private const string PropertyobjectXml = "objectXml";
        private const string PropertyobjectDom = "objectDom";

        #endregion

        #region Fields

        private const string FieldObjectId = "ObjectId";
        private const string FieldLbo = "Lbo";
        private const string FieldInsertLbm = "InsertLbm";
        private const string FieldUpdateLbm = "UpdateLbm";
        private const string FieldObjectXml = "ObjectXml";
        private const string FieldObjectDom = "ObjectDom";
        private const string FielddependentObjects = "dependentObjects";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (LogicalObject)

        #region General Initializer : Class (LogicalObject) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LogicalObject" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LogicalObject_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (LogicalObject) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="LogicalObject" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDependentObjects)]
        [TestCase(PropertyobjectId)]
        [TestCase(PropertyLBO)]
        [TestCase(PropertyinsertLBM)]
        [TestCase(PropertyupdateLBM)]
        [TestCase(PropertyobjectXml)]
        [TestCase(PropertyobjectDom)]
        [Category("AUT Property")]
        public void AUT_LogicalObject_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (LogicalObject) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="LogicalObject" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LogicalObject_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (LogicalObject) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LogicalObject" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldObjectId)]
        [TestCase(FieldLbo)]
        [TestCase(FieldInsertLbm)]
        [TestCase(FieldUpdateLbm)]
        [TestCase(FieldObjectXml)]
        [TestCase(FieldObjectDom)]
        [TestCase(FielddependentObjects)]
        [Category("AUT Fields")]
        public void AUT_LogicalObject_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (LogicalObject) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LogicalObject" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LogicalObject_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (LogicalObject) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDependentObjects)]
        [TestCase(PropertyobjectId)]
        [TestCase(PropertyLBO)]
        [TestCase(PropertyinsertLBM)]
        [TestCase(PropertyupdateLBM)]
        [TestCase(PropertyobjectXml)]
        [TestCase(PropertyobjectDom)]
        public void AUT_LogicalObject_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (LogicalObject) => Property (DependentObjects) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LogicalObject_Public_Class_DependentObjects_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDependentObjects);
            var propertyInfo = this.GetPropertyInfo(PropertyDependentObjects);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LogicalObject) => Property (insertLBM) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LogicalObject_Public_Class_insertLBM_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyinsertLBM);
            var propertyInfo = this.GetPropertyInfo(PropertyinsertLBM);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LogicalObject) => Property (LBO) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LogicalObject_Public_Class_LBO_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLBO);
            var propertyInfo = this.GetPropertyInfo(PropertyLBO);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LogicalObject) => Property (objectDom) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LogicalObject_objectDom_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyobjectDom);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyobjectDom);
            Action currentAction = () => propertyInfo.SetValue(_logicalObjectInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (LogicalObject) => Property (objectDom) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LogicalObject_Public_Class_objectDom_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyobjectDom);
            var propertyInfo = this.GetPropertyInfo(PropertyobjectDom);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LogicalObject) => Property (objectId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LogicalObject_Public_Class_objectId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyobjectId);
            var propertyInfo = this.GetPropertyInfo(PropertyobjectId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LogicalObject) => Property (objectXml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LogicalObject_Public_Class_objectXml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyobjectXml);
            var propertyInfo = this.GetPropertyInfo(PropertyobjectXml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (LogicalObject) => Property (updateLBM) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_LogicalObject_Public_Class_updateLBM_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyupdateLBM);
            var propertyInfo = this.GetPropertyInfo(PropertyupdateLBM);

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