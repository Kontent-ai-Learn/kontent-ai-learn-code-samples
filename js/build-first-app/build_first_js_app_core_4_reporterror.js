// Error messages
const reportErrors = err => {
  console.error(err);
  app.innerHTML = `<p>An error occured 😞:</p><p><i>${err}</i></p>`;
};
