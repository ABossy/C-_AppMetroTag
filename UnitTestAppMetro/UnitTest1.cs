using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using TagLibrary;




namespace UnitTestAppMetro
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void TestMethod1_WithMock()
        {
            MockFactory mockFactory = new MockFactory();
            Mock<IApiRequest> mockIApiRequest = mockFactory.CreateMock<IApiRequest>();
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.JsonNearYou);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.json13);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.json16);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.jsonC4);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.jsonC1);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.json57);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.jsonC4);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.json13);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.json16);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.json12);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.jsonEXP2);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.jsonEXP1);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.json6200);
            mockIApiRequest.Expects.One.Method(_ => _.Request("")).WithAnyArguments().WillReturn(Json.json6060);
            Station test = new Station(mockIApiRequest.MockObject);
            Dictionary<string, List<ChampRoute>> result = test.GetStation();

            Assert.AreEqual(3, result.Count);
            Assert.IsTrue(result.ContainsKey("GRENOBLE, CASERNE DE BONNE"));
            Assert.AreEqual("SEM:13", result["GRENOBLE, CASERNE DE BONNE"][0].Id);
            Assert.AreEqual("SEM:16", result["GRENOBLE, CASERNE DE BONNE"][1].Id);
            Assert.AreEqual("SEM:C4", result["GRENOBLE, CASERNE DE BONNE"][2].Id);
                        
            Assert.IsTrue(result.ContainsKey("GRENOBLE, DOCTEUR MARTIN"));
            Assert.IsTrue(result.ContainsKey("GRENOBLE, CHAVANT"));
            //Assert.IsTrue(result.ContainsKey("victor hugo"));
        }
    }
}
