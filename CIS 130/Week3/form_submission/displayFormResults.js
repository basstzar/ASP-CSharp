//script for displayFormResults.html
//this script is designed to grab the url, strip it to just the form values passed and then open a new window with just those values displayed
    var url=window.location.href;      //will store the url in the address bar
    var tempArray = new Array();    //used to store name/value pairs until it can be split into just name and value
    var pairsArray = []
    var elementNameArray = [];      //holds the names of the form elements passed across the URL
    var elementValueArray = [];      //holds the values of the form elements passed across the URL
  
  function getFormData() {
      //strip out first part of url up to form data
      formDataStart = url.indexOf("?");
      formData = unescape(url.substring(formDataStart+1,url.length));

      //split url into name=value pairs on the & symbol  
      pairsArray = formData.split("&"); 
      
      //split name=value paris (in each element of the array) by = sign and assign to elements of 2 new arrays
      for (var i=0; i<pairsArray.length; i++) { 
        idx = pairsArray[i].indexOf("=");   
        elementNameArray[i] = pairsArray[i].substring(0,idx);
        elementValueArray[i] = pairsArray[i].replace(/\+/g," ").substring(idx+1);
      }
      
      pageContent = '<table><tr><th width="150">Element Name</th><th width="275">Element Value</th></tr>';
      
      for (var i=0; i<elementNameArray.length; i++) {
        pageContent += '<tr><td>' + elementNameArray[i] + '</td>';
        pageContent += '<td>' + elementValueArray[i] + '</td></tr>';
      }
      
      pageContent += '</table><br />'
      pageContent += '<a href="#" onclick="self.close();return false;">Close this window</a>';
      document.write(pageContent)
  }
