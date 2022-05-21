var express = require("express");
var router = express.Router();

router.get("/", function (req, res, next) {
    res.send("Mostrar la lista de ciudades");
});

router.get("/:id", function (req, res, next) {
    res.send("Mostrar los datos de una ciudad");
});

router.post("/", function (req, res, next) {
    res.send("Hacer algo");
});

module.exports = router;
