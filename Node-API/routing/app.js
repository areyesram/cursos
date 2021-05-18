const express = require("express");
const app = express();

app.use(express.json());

app.use((req, res, next) => {
    console.log(`${req.method} ${req.url}`);
    next();
});

app.use("/", require("./routes/index"));
app.use("/cities", require("./routes/cities"));

const port = 3000;

app.listen(port, () => {
    console.log(`http://localhost:${port}`);
});
