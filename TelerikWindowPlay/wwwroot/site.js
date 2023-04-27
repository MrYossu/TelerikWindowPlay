function ShowWindow(windowClass) {
  console.log('ShowWindow("' + windowClass + '")');
  var winds = document.getElementsByClassName(windowClass);
  console.log("Found " + winds.length + " matching window(s)");
  var wind = winds[0];
  if (wind == null) {
    console.log("Can't find the window");
  } else {
    console.log("Found the window");
  }
  wind.click();
}