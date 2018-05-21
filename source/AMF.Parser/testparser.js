

var parser = require('parser');
//var util = require('util')

console.log('Start');

try {
    var filepath = "file:///desarrollo/mulesoft/amf-dotnet-parser/source/AMF.Parser.Tests/specs/chinook-v1.raml"
    parser.parse('raml', filepath, function (m) {
        console.log(m);
    });
}
catch(ex){
    console.log(ex);
}

// var filepath = "file:///desarrollo/mulesoft/amf-dotnet-parser/source/AMF.Parser.Tests/specs/arrayTypes.raml"
// parser.parse('raml', filepath, function (m) {
//     console.log(m);
// });

// var filepath = "file:///desarrollo/mulesoft/amf-dotnet-parser/source/AMF.Parser.Tests/specs/typeExpressions.raml"
// parser.parse('raml', filepath, function (m) {
//     console.log(m);
// });


// var filepath = "file:///desarrollo/mulesoft/amf-dotnet-parser/source/AMF.Parser.Tests/specs/oas/yaml/api-with-examples.yaml"
// parser.parse('oas', filepath, function (m) {
//     console.log(m);
// });