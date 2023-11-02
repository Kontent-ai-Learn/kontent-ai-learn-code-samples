// Define main container
const app = document.getElementById('app');

// Function for creating and appending elements
const addToElementbyId = (elementType, id, parent) => {
  const element = document.createElement(elementType);
  element.setAttribute('id', id);
  parent.appendChild(element);
  return element;
};
