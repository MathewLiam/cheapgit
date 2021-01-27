import React, { useEffect, useState } from 'react'
import { Button, Card, CardColumns } from 'react-bootstrap';

const ProductExplorer = ({ settings }) => {
    const [products, setProducts] = useState({ search_results: [] });

    useEffect(() => {
        fetch(`/api/v1/amazon/search?searchterm=${settings.searchterm}&categoryid=${settings.categoryid}`)
        .then(response => response.json())
        .then(data => setProducts(data))
    }, []);

    if (products.search_results == []) {
        return (
            <Spinner animation="border" />
        )
    } else {
        return (
            <CardColumns>
                {products.search_results.map((item, index) => {
                    return (
                        <Card key={index}>
                            <Card.Img variant="top" src={item.image} />
                            <Card.Body>
                                <Card.Title>{item.title}</Card.Title>
                                
                            </Card.Body>
                            <Card.Footer>
                                <Button href={item.link}>Go To Amazon</Button>
                                <p>{item.price ? item.price.raw : null}</p>
                            </Card.Footer>
                        </Card>
                    )
                })}
            </CardColumns>
            
        ) 
    }
}

export default ProductExplorer;