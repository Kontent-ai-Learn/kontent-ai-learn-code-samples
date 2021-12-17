// DocSection: build_first_js_app_core_3_createelement
// Function for adding elements to DOM with specific attributes
const createElement = (elementType, classToAdd, attribute, attributeValue) => {
    const element = document.createElement(elementType);
    element.setAttribute('class', classToAdd);
  
    // Set attribute value based on the attribute required
    attribute === 'href'
      ? (element.href = attributeValue)
      : attribute === 'innerHTML'
      ? (element.innerHTML = attributeValue)
      : attribute === 'innerText'
      ? (element.innerText = attributeValue)
      : attribute === 'src'
      ? (element.src = attributeValue)
      : undefined;
  
    return element;
  };
// EndDocSection