// App.js
import React, { useState } from 'react';
import './App.css';

function App() {
    const [query, setQuery] = useState('');
    const [recipes, setRecipes] = useState([]);
    const [loading, setLoading] = useState(false);

    const fetchRecipes = async () => {
        setLoading(true);
        try {
            const response = await fetch(
                `https://api.edamam.com/search?q=${query}&app_id=YOUR_APP_ID&app_key=YOUR_APP_KEY`
            );
            const data = await response.json();
            setRecipes(data.hits);
        } catch (error) {
            console.error('Error fetching recipes:', error);
        }
        setLoading(false);
    };

    const handleSearch = (e) => {
        e.preventDefault();
        if (query.trim()) {
            fetchRecipes();
        }
    };

    return (
        <div className="App">
            <header className="App-header">
                <h1>Recipe Search Engine</h1>
                <form onSubmit={handleSearch}>
                    <input
                        type="text"
                        placeholder="Search for recipes..."
                        value={query}
                        onChange={(e) => setQuery(e.target.value)}
                    />
                    <button type="submit">Search</button>
                </form>
            </header>
            <main>
                {loading && <p>Loading...</p>}
                <div className="recipes">
                    {recipes.map((recipe, index) => (
                        <div key={index} className="recipe">
                            <h2>{recipe.recipe.label}</h2>
                            <img src={recipe.recipe.image} alt={recipe.recipe.label} />
                            <p>
                                <a href={recipe.recipe.url} target="_blank" rel="noopener noreferrer">
                                    View Recipe
                                </a>
                            </p>
                        </div>
                    ))}
                </div>
            </main>
        </div>
    );
}

export default App;
