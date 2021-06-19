const express = require("express");
const app = express();
app.get("/", (req, res) => {
    res.send("<html>" +
        "<head><title>Hello</title></head>" +
        "<body>Hello World!</body>" +
        "</html>");
});
const port = 3000;
app.listen(port, () => console.log(`http://localhost:${port}`));
