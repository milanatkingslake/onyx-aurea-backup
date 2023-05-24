using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.DataQueryGroup" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DataQueryGroupTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DataQueryGroup" />)
        /// </summary>
        public DataQueryGroupTest() : base(typeof(DataQueryGroup))
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

        #region General Initializer : Class (DataQueryGroup) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dataQueryGroupInstanceType;
        private DataQueryGroup _dataQueryGroupInstance;
        private DataQueryGroup _dataQueryGroupInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DataQueryGroup" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dataQueryGroupInstanceType = typeof(DataQueryGroup);
            _dataQueryGroupInstanceFixture = this.Create<DataQueryGroup>(false);
            _dataQueryGroupInstance = _dataQueryGroupInstanceFixture ?? this.Create<DataQueryGroup>(true);
            CurrentInstance = _dataQueryGroupInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DataQueryGroup) Initializer

        #region Properties

        private const string PropertyProtectionMode = "ProtectionMode";

        #endregion

        #region Fields

        private const string FieldFolderId = "FolderId";
        private const string FieldFolderName = "FolderName";
        private const string FieldParentFolderId = "ParentFolderId";
        private const string FieldOwnerId = "OwnerId";
        private const string FieldInsertBy = "InsertBy";
        private const string FieldInsertDate = "InsertDate";
        private const string FieldUpdateBy = "UpdateBy";
        private const string FieldUpdateDate = "UpdateDate";

        #endregion

        #endregion

        #region General Initializer : Class (DataQueryGroup) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DataQueryGroup" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DataQueryGroup_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DataQueryGroup) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DataQueryGroup" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DataQueryGroup_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DataQueryGroup) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DataQueryGroup" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DataQueryGroup_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DataQueryGroup)

        #region General Initializer : Class (DataQueryGroup) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DataQueryGroup" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyProtectionMode)]
        [Category("AUT Property")]
        public void AUT_DataQueryGroup_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (DataQueryGroup) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DataQueryGroup" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldFolderId)]
        [TestCase(FieldFolderName)]
        [TestCase(FieldParentFolderId)]
        [TestCase(FieldOwnerId)]
        [TestCase(FieldInsertBy)]
        [TestCase(FieldInsertDate)]
        [TestCase(FieldUpdateBy)]
        [TestCase(FieldUpdateDate)]
        [Category("AUT Fields")]
        public void AUT_DataQueryGroup_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DataQueryGroup) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DataQueryGroup" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DataQueryGroup_Is_Instance_Present_Test()
        {
            // Assert
            _dataQueryGroupInstanceType.ShouldNotBeNull();
            _dataQueryGroupInstance.ShouldNotBeNull();
            _dataQueryGroupInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DataQueryGroup) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DataQueryGroup" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DataQueryGroup_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dataQueryGroupInstance.ShouldBeAssignableTo<DataQueryGroup>();
            _dataQueryGroupInstanceFixture.ShouldBeAssignableTo<DataQueryGroup>();
            CurrentInstance.ShouldBeAssignableTo<DataQueryGroup>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DataQueryGroup) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DataQueryGroup_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DataQueryGroup instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DataQueryGroup) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyProtectionMode)]
        public void AUT_DataQueryGroup_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (DataQueryGroup) => Property (ProtectionMode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DataQueryGroup_Public_Class_ProtectionMode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProtectionMode);
            var propertyInfo = this.GetPropertyInfo(PropertyProtectionMode);

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