// DocSection: build_first_js_app_core_1_main_constants
// Define main container
const app = document.getElementById('app');

// Function for creating and appending elements
const addToElementbyId = (elementType, id, parent) => {
  const element = document.createElement(elementType);
  element.setAttribute('id', id);
  parent.appendChild(element);
  return element;
};
// EndDocSection