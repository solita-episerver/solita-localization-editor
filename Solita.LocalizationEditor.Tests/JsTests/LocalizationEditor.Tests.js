/// <reference path="http://code.jquery.com/qunit/qunit-1.19.0.js" />
/// <reference path="..\..\Solita.LocalizationEditor.UI\Modules\_protected\Solita.LocalizationEditor.UI\js\LocalizationEditor.js" />

QUnit.module("LocalizationEditor tests");

QUnit.test("hello test", function (assert) {
    assert.ok(1 == "1", "Passed!");
});

QUnit.test("loads modules", function(assert) {
    assert.notEqual("undefined", domUpdateHelper);
    assert.notEqual("undefined", localizationsParser);
    assert.notEqual("undefined", $);
});






