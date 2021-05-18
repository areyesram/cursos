const express = require("express");
const router = express.Router();

const _data = [
    { ID: 1, Name: "Monterrey" },
    { ID: 2, Name: "Guadalupe" },
    { ID: 3, Name: "San Pedro" },
    { ID: 4, Name: "San Nicolás" },
    { ID: 5, Name: "Escobedo" },
    { ID: 6, Name: "Apodaca" },
    { ID: 7, Name: "Juárez" },
];

router.get("/", (req, res) => {
    res.json(_data);
});

router.get("/:id", (req, res) => {
    const id = req.params.id;
    res.json(_data.find((o) => o.ID == id));
});

router.post("/:id?", (req, res) => {
    const id = req.params.id;
    // guardar usuario
    res.json({});
});

module.exports = router;
