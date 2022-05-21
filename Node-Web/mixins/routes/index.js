var express = require("express");
var router = express.Router();

/* GET home page. */
router.get("/", function (req, res, next) {
    const data = [
        { caption: "English", items: ["One", "Two", "Three"] },
        { caption: "Español", items: ["Uno", "Dos", "Tres"] },
    ];
    res.render("index", { title: "Express", data });
});

module.exports = router;
