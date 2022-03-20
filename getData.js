const request = require("request");
const fs = require("fs");
const { time } = require("console");

const date = new Date();
("use strict");
const url = "https://cebcare.ceb.lk/Incognito/GetLoadSheddingEvents";

request.post(
  {
    url: url,
    json: true,
    headers: {
      "User-Agent": "request",
      Cookie:
        ".AspNetCore.Antiforgery.ThOcTlhnrMo=CfDJ8DRug-ybtbxAjw2fB8wdOCNFI98Jv_Jwb7v7LVad84zXCqypz2plALDzqEPkKUB8OMjniOAj80fiZA0fy-Ld9uzzmApq5TmqWYyJHib5ajckBJ1_GPh4euVbSDvSODNzdAaP8N4CxqWvuxNj5ftu9Zc",
      RequestVerificationToken:
        "CfDJ8DRug-ybtbxAjw2fB8wdOCOVCtuvvGJqobQz-1nkU3ndefl5UgXmsO5OGq3FR30MbhT0cdB_NrbdhSfqrNaA-LbqTJRd2-fbDStpFxQagsrt0p2VHa4no5UjFwv6T-JwogQGhA4zMSpducoqFz8GVP8",
    },
  },
  (err, res, data) => {
    if (err) {
      console.log("Error:", err);
    } else if (res.statusCode !== 200) {
      console.log("Status:", res.statusCode);
    } else {
      //clean the file
      fs.writeFile("./test.txt", "", (err) => {
        if (err) {
          console.error(err);
          return;
        }
      });
      //write updated values
      let times = [];
      data.filter((item) => {
        if (item.loadShedGroupId == "I" && new Date(item.startTime).getDate() == date.getDate()) {
          times.push(item.startTime,item.endTime)
        }
      });
      times.sort();
      console.log(times);
      let string = times[0].slice(11) + "\n" + times[1].slice(11) + "\n"+ times[2].slice(11) + "\n"+ times[3].slice(11) + "\n"
      fs.appendFile("./test.txt", string, (err) => {
        if (err) {
          console.error(err);
          return;
        }
        //file written successfully
      });
    }
  }
);
