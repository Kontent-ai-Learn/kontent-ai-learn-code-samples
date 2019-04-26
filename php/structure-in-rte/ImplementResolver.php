// DocSection: structure_in_rte_implement_resolver
<?php

class CustomLinkedItemsResolver implements InlineLinkedItemsResolverInterface
{
    public function resolveInlineLinkedItems($input, $item)
    {
        if(empty($item)){
            return $input; 
        }

        switch ($item->system->type) {
            case 'tweet':
                return "<blockquote class=\"twitter-tweet\" data-lang=\"en\" data-theme=\"".$item->elements->theme->value[0]->codename."\"><a href=\"".$item->elements->tweet_link->value."\"></a></blockquote>";
        }

        return $input;
    }
}
// EndDocSection